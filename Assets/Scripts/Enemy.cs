using UnityEngine;

public class Enemy : MonoBehaviour {

    

    private Transform target;
    private int wavePointIndex = 0;

    [Header ("Attribute")]
    public int killReward = 100;
    public float speed = 10f;
    public int health = 1;
    public int dmg = 1;
    public float flightAltitude = 0f;

    void Start ()
    {
        target = Waypoints.wayPoints[0];
    }

    void Update ()
    {

        Vector3 dir;
        // Ist der Gegner ein "Luftgegner" und muss er noch "aufsteigen"
        if (this.gameObject.transform.position.y - 2 < flightAltitude)
        {
            dir = new Vector3(0, 1, 0);
        }
        else
        {
            dir = new Vector3(target.position.x, target.position.y + flightAltitude, target.position.z) - transform.position;
        }
        // Ist der Gegner ein "Luftgegner" und muss am Ziel wieder "absteigen"
        if (wavePointIndex >= Waypoints.wayPoints.Length - 1 && flightAltitude != 0 && Vector3.Distance(transform.position, new Vector3(target.position.x, target.position.y + this.gameObject.transform.position.y - 2, target.position.z)) <= 0.4f)
        {
            dir = new Vector3(0, -1, 0);
            GetNextWaypoint();
        }

        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, new Vector3(target.position.x, target.position.y + flightAltitude, target.position.z)) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        // Ist der Gegner noch über dem Ziel? --> return zu Update()
        if (this.gameObject.transform.position.y > target.position.y && wavePointIndex >= Waypoints.wayPoints.Length - 1 && flightAltitude != 0)
            return;

        // Hat der Gegner das Ziel erreicht?
        if (wavePointIndex >= Waypoints.wayPoints.Length - 1)
        { 
            PlayerStats.Health -= dmg;
            Destroy(gameObject);
            return;      
        }

        wavePointIndex++;
        target = Waypoints.wayPoints[wavePointIndex];
    }

    public void EnemyDestroy()
    {

        PlayerStats.Money += killReward;

    }    

}
