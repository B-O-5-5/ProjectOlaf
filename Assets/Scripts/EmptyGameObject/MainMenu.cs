using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public float musicVolume = 0.5f;

    void Update()
    {

        musicVolume = FindObjectOfType<AudioSource>().volume;

    }

    public void PlayGame (int zaehler)
    {

        PlayerPrefs.SetFloat("MusicVolume", musicVolume);

        Application.LoadLevel(zaehler);

    }


    public void ExitGame()
    {
        Application.Quit();
    }
}
