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
        Vector3 dir = new Vector3(target.position.x, target.position.y + flightAltitude, target.position.z) - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, new Vector3(target.position.x, target.position.y + flightAltitude, target.position.z)) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
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
