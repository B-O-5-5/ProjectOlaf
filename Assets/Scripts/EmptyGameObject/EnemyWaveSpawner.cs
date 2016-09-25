using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyWaveSpawner : MonoBehaviour {

    public Transform enemyPrefab;
    public Transform enemy2Prefab;
    public Transform enemy3Prefab;
    public Transform spawnPoint;

    public Text waveCounterText;

	public string enemyTag = "Enemy";

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    public WaveManager[] Waves;

    GameObject[] enemies;

    private int waveNumber = 0;

    void Start()
    {
        StartCoroutine(SpawnWave());
    }

    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        /***
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }


        if (enemies.Length == 0)
        {
            countdown -= Time.deltaTime;
        }
        ***/
    }

    IEnumerator SpawnWave()
    {

        foreach (WaveManager wave in Waves)
        {
            waveNumber++;
            waveCounterText.text = waveNumber.ToString();

            for (int i = 0; i < wave.anzahlEnemies; i++)
            {
                SpawnEnemy();

                yield return new WaitForSeconds(0.5f);
            }
            for (int i = 0; i < wave.anzahlEnemies2; i++)
            {
                SpawnEnemy2();

                yield return new WaitForSeconds(0.5f);
            }

            for (int i = 0; i < wave.anzahlEnemies3; i++)
            {
                SpawnEnemy3();

                yield return new WaitForSeconds(0.5f);
            }

            
            while (enemies.Length > 0)
            {
                yield return null;
            }

            yield return new WaitForSeconds(timeBetweenWaves);
        }
    }
	

    void SpawnEnemy()
    {

        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

    }

    void SpawnEnemy2()
    {

        Instantiate(enemy2Prefab, spawnPoint.position, spawnPoint.rotation);

    }

    void SpawnEnemy3()
    {

        Instantiate(enemy3Prefab, spawnPoint.position, spawnPoint.rotation);

    }
}
