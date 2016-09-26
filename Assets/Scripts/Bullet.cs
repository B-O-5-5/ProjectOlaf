using UnityEngine;

public class Bullet : MonoBehaviour {

    private GameObject target;
    public string turretTag = "Turret";

    public float speed = 70f;
    public float explosionRadius = 0;
    public GameObject impactEffect;
    private int dmg;

    public void Seek (GameObject _target)
    {

        target = _target;

    }
	
    void Start()
    {
        GetDamageOfTurret();
    } 

	// Update is called once per frame
	void Update ()
    {
	    
        if(target == null)
        {

            GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(effectIns, 2f);

            if (explosionRadius > 0f)
            {
                Explode();
            }

            Destroy(gameObject);
            return;

        }

        Vector3 dir = target.transform.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target.transform);


	}

    void HitTarget()
    {

        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);

        if (explosionRadius > 0f)
        {
            Explode();
        }
        else
        {
            Damage(target);
        }
        
        Destroy(gameObject);

    }

    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach(Collider collider in colliders)
        {
            if(collider.tag == "EnemyGround")
            {
                Damage(collider.gameObject);
            }
        }
    }

    void Damage (GameObject enemy)
    {

        if (enemy.GetComponent<Enemy>().health > 0)
        {
            enemy.GetComponent<Enemy>().health -= dmg;
        }
        if (enemy.GetComponent<Enemy>().health <= 0)
        {
            enemy.GetComponent<Enemy>().EnemyDestroy();
            Destroy(enemy.gameObject);
        }
    }

    void  GetDamageOfTurret()
    {
        GameObject[] turrets = GameObject.FindGameObjectsWithTag(turretTag);

        float shortestDistance = Mathf.Infinity;
        GameObject nearestTurret = null;


        foreach (GameObject turret in turrets)
        {
            float distanceToTurret = Vector3.Distance(transform.position, turret.transform.position);
            if (distanceToTurret < shortestDistance)
            {
                shortestDistance = distanceToTurret;
                nearestTurret = turret;
            }
    
        }
        dmg = nearestTurret.GetComponent<Turret>().dmg;
    }
}
