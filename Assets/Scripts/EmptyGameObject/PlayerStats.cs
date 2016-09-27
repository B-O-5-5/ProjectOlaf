using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

    public static int Health;
    public int startHealth = 100;

    public static int Money;
    public int startMoney = 400;

    public Text playerHealthText;
    public Text playerMoneyText;

    public GameObject WinScreen;
    public GameObject LooseScreen;

    void Start()
    {
        Health = startHealth;
        Money = startMoney;
    }

    void Update()
    {
        playerHealthText.text = Health.ToString() + " <3";
        playerMoneyText.text = Money.ToString() + "$";

        if (Health <= 0)
        {
            LooseScreen.SetActive(true);
        }
        if (Health >= 0 && this.GetComponent<EnemyWaveSpawner>().gameEnd && this.GetComponent<EnemyWaveSpawner>().waveNumber == this.GetComponent<EnemyWaveSpawner>().Waves.Length)
        {
            WinScreen.SetActive(true);
        }
    }

}
