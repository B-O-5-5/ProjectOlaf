using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public float musicVolume = 0.5f;
    public int dankMusic = 0;

    public bool test = false;

    void Update()
    {
        test= FindObjectOfType<Toggle>().isOn;
        musicVolume = FindObjectOfType<AudioSource>().volume;

        dankMusic = GetPlaylistStatus();

    }

    public void PlayGame (int zaehler)
    {

        PlayerPrefs.SetFloat("MusicVolume", musicVolume);
        PlayerPrefs.SetInt("PlaylistStatus", dankMusic);

        Application.LoadLevel(zaehler);

    }


    public void ExitGame()
    {
        Application.Quit();
    }


    public int GetPlaylistStatus()
    {
        if (test)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
