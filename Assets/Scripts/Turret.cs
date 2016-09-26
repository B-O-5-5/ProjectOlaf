using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {

    private GameObject target;

    [Header("Attributes")]
    public float range = 15f;
    public float fireRate = 1f;
    private float firCountdown = 0f;
    public int dmg = 1;
    public bool AntiAirTurret;
    public bool AntiGroundTurret;

    [Header("Unity Setup Fields")]
    public string enemyTagGround = "EnemyGround";
    public string enemyTagAir = "EnemyAir";

    public Transform partToRotate;
    public float turnSpeed = 5f;

    public GameObject bulletPrefab;
    public Transform firePoint;

    // Use this for initialization
    void Start () {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
	}

    void UpdateTarget()
    {


        GameObject[] enemiesAir = GameObject.FindGameObjectsWithTag(enemyTagAir);
        GameObject[] enemiesGround = GameObject.FindGameObjectsWithTag(enemyTagGround);

        GameObject[] enemies = new GameObject[enemiesGround.Length + enemiesAir.Length];

        if (AntiGroundTurret && AntiAirTurret)
        {
            enemiesGround.CopyTo(enemies, 0);
            enemiesAir.CopyTo(enemies, enemiesGround.Length);
        }
        else if (AntiGroundTurret)
        {
            enemies = enemiesGround;
        }
        else if (AntiAirTurret)
        {
            enemies = enemiesAir;
        }
        else
        {
            Debug.Log("Kein Schussmodi audgewählt!");
        }

        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if(distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
            
        }

        if(nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.gameObject;
        }
        else
        {
            target = null;
        }

    }
	
	// Update is called once per frame
	void Update () {

        firCountdown -= Time.deltaTime;

        if (target == null)
            return;

        Vector3 dir = target.transform.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler (0f, rotation.y, 0f);

        if(firCountdown <= 0)
        {
            Shoot();
            firCountdown = 1f / fireRate;

        } 

	}

    void Shoot()
    {
        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if (bullet != null)
            bullet.Seek(target.gameObject);
    }

    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);

    }
}
