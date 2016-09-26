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

	[Header("Wellen")]
	public WaveManager Wave_1;
	public WaveManager Wave_2;
	public WaveManager Wave_3;
	public WaveManager Wave_4;
	public WaveManager Wave_5;
	public WaveManager Wave_6;
	public WaveManager Wave_7;
	public WaveManager Wave_8;
	public WaveManager Wave_9;
	public WaveManager Wave_10;

    private int waveNumber = 0;

    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }
		GameObject[] enemies = GameObject.FindGameObjectsWithTag (enemyTagGround);
			
		if (enemies.Length == 0)
		{
        	countdown -= Time.deltaTime;
		}
    }

    IEnumerator SpawnWave()
    {

        waveNumber++;
        waveCounterText.text = waveNumber.ToString();

		if (waveNumber == 1) {			
		
        	for (int i = 0; i < Wave_1.anzahlEnemies; i++)
        	{
            	SpawnEnemy();

            	yield return new WaitForSeconds(0.5f);
            }
            for (int i = 0; i < Wave_1.anzahlEnemies2; i++)
            {
                SpawnEnemy2();

                yield return new WaitForSeconds(0.5f);
            }

            for (int i = 0; i < Wave_1.anzahlEnemies3; i++)
            {
                SpawnEnemy3();

                yield return new WaitForSeconds(0.5f);
            }

            for (int i = 0; i < Wave_1.anzahlEnemies4; i++)
            {
                SpawnEnemy4();

                yield return new WaitForSeconds(0.5f);
            }
        }
		else if (waveNumber == 2) {			

			for (int i = 0; i < Wave_2.anzahlEnemies; i++)
			{
				SpawnEnemy();

				yield return new WaitForSeconds(0.5f);
			}
            for (int i = 0; i < Wave_2.anzahlEnemies2; i++)
            {
                SpawnEnemy2();

                yield return new WaitForSeconds(0.5f);
            }

            for (int i = 0; i < Wave_2.anzahlEnemies3; i++)
            {
                SpawnEnemy3();

                yield return new WaitForSeconds(0.5f);
            }
            for (int i = 0; i < Wave_2.anzahlEnemies4; i++)
            {
                SpawnEnemy4();

                yield return new WaitForSeconds(0.5f);
            }
        }
		else if (waveNumber == 3) {			

			for (int i = 0; i < Wave_3.anzahlEnemies; i++)
			{
				SpawnEnemy();

				yield return new WaitForSeconds(0.5f);
			}
            for (int i = 0; i < Wave_3.anzahlEnemies2; i++)
            {
                SpawnEnemy2();

                yield return new WaitForSeconds(0.5f);
            }
            for (int i = 0; i < Wave_3.anzahlEnemies3; i++)
            {
                SpawnEnemy3();

                yield return new WaitForSeconds(0.5f);
            }
            for (int i = 0; i < Wave_3.anzahlEnemies4; i++)
            {
                SpawnEnemy4();

                yield return new WaitForSeconds(0.5f);
            }
        }
		else if (waveNumber == 4) {			

			for (int i = 0; i < Wave_4.anzahlEnemies; i++)
			{
				SpawnEnemy();

				yield return new WaitForSeconds(0.5f);
			}
            for (int i = 0; i < Wave_4.anzahlEnemies2; i++)
            {
                SpawnEnemy2();

                yield return new WaitForSeconds(0.5f);
            }

            for (int i = 0; i < Wave_4.anzahlEnemies3; i++)
            {
                SpawnEnemy3();

                yield return new WaitForSeconds(0.5f);
            }
            for (int i = 0; i < Wave_4.anzahlEnemies4; i++)
            {
                SpawnEnemy4();

                yield return new WaitForSeconds(0.5f);
            }
        }
		else if (waveNumber == 5) {			

			for (int i = 0; i < Wave_5.anzahlEnemies; i++) {
				SpawnEnemy ();

				yield return new WaitForSeconds (0.5f);
			}
            for (int i = 0; i < Wave_5.anzahlEnemies2; i++)
            {
                SpawnEnemy2();

                yield return new WaitForSeconds(0.5f);
            }

            for (int i = 0; i < Wave_5.anzahlEnemies3; i++)
            {
                SpawnEnemy3();

                yield return new WaitForSeconds(0.5f);
            }
            for (int i = 0; i < Wave_5.anzahlEnemies4; i++)
            {
                SpawnEnemy4();

                yield return new WaitForSeconds(0.5f);
            }
        }
        else if (waveNumber == 6) {			

			for (int i = 0; i < Wave_6.anzahlEnemies; i++) {
				SpawnEnemy ();

				yield return new WaitForSeconds (0.5f);
			}
            for (int i = 0; i < Wave_6.anzahlEnemies2; i++)
            {
                SpawnEnemy2();

                yield return new WaitForSeconds(0.5f);
            }

            for (int i = 0; i < Wave_6.anzahlEnemies3; i++)
            {
                SpawnEnemy3();

                yield return new WaitForSeconds(0.5f);
            }
            for (int i = 0; i < Wave_6.anzahlEnemies4; i++)
            {
                SpawnEnemy4();

                yield return new WaitForSeconds(0.5f);
            }
        }
        else if (waveNumber == 7) {			

			for (int i = 0; i < Wave_7.anzahlEnemies; i++) {
				SpawnEnemy ();

				yield return new WaitForSeconds (0.5f);
			}
            for (int i = 0; i < Wave_7.anzahlEnemies2; i++)
            {
                SpawnEnemy2();

                yield return new WaitForSeconds(0.5f);
            }

            for (int i = 0; i < Wave_7.anzahlEnemies3; i++)
            {
                SpawnEnemy3();

                yield return new WaitForSeconds(0.5f);
            }
            for (int i = 0; i < Wave_7.anzahlEnemies4; i++)
            {
                SpawnEnemy4();

                yield return new WaitForSeconds(0.5f);
            }
        }
        else if (waveNumber == 8) {			

			for (int i = 0; i < Wave_8.anzahlEnemies; i++) {
				SpawnEnemy ();

				yield return new WaitForSeconds (0.5f);
			}
            for (int i = 0; i < Wave_8.anzahlEnemies2; i++)
            {
                SpawnEnemy2();

                yield return new WaitForSeconds(0.5f);
            }

            for (int i = 0; i < Wave_8.anzahlEnemies3; i++)
            {
                SpawnEnemy3();

                yield return new WaitForSeconds(0.5f);
            }
            for (int i = 0; i < Wave_8.anzahlEnemies4; i++)
            {
                SpawnEnemy4();

                yield return new WaitForSeconds(0.5f);
            }
        }
        else if (waveNumber == 9) {			

			for (int i = 0; i < Wave_9.anzahlEnemies; i++) {
				SpawnEnemy ();

				yield return new WaitForSeconds (0.5f);
			}
            for (int i = 0; i < Wave_9.anzahlEnemies2; i++)
            {
                SpawnEnemy2();

                yield return new WaitForSeconds(0.5f);
            }

            for (int i = 0; i < Wave_9.anzahlEnemies3; i++)
            {
                SpawnEnemy3();

                yield return new WaitForSeconds(0.5f);
            }
            for (int i = 0; i < Wave_9.anzahlEnemies4; i++)
            {
                SpawnEnemy4();

                yield return new WaitForSeconds(0.5f);
            }
        }
        else if (waveNumber == 10) {			

			for (int i = 0; i < Wave_10.anzahlEnemies; i++) {
				SpawnEnemy ();

				yield return new WaitForSeconds (0.5f);
			}
            for (int i = 0; i < Wave_10.anzahlEnemies2; i++)
            {
                SpawnEnemy2();

                yield return new WaitForSeconds(0.5f);
            }
            for (int i = 0; i < Wave_10.anzahlEnemies3; i++)
            {
                SpawnEnemy3();

                yield return new WaitForSeconds(0.5f);
            }
            for (int i = 0; i < Wave_10.anzahlEnemies4; i++)
            {
                SpawnEnemy4();

                yield return new WaitForSeconds(0.5f);
            }
        }
        else
        {
			Debug.Log ("Alle Wellen besiegt!!!11!!!1!");
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
