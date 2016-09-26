using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyWaveSpawner : MonoBehaviour {

    public Transform enemyPrefab;
    public Transform enemy2Prefab;
    public Transform enemy3Prefab;
    public Transform enemy4Prefab;
    public Transform spawnPoint;

    public Text waveCounterText;

	public string enemyTagGround = "EnemyGround";

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    public WaveManager[] Waves;

    private int waveNumber = 0;
    GameObject[] enemies;

    void Start()
    {
        StartCoroutine(SpawnWave());
    }

    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag(enemyTagGround);
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

            for (int i = 0; i < wave.anzahlEnemies4; i++)
            {
                SpawnEnemy4();

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

    void SpawnEnemy4()
    {

        Instantiate(enemy4Prefab, spawnPoint.position, spawnPoint.rotation);

    }
}
