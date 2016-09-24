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
            print("Game Over!");
            Application.LoadLevel(0);
        }
    }

}
