using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

    public AudioClip[] RickAstelyPlaylist;
    public AudioClip[] RealPlaylist;
    private AudioSource audioSource;
    private int DankMusic = 0;

    void Start ()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
        audioSource.volume = PlayerPrefs.GetFloat("MusicVolume");
        DankMusic = PlayerPrefs.GetInt("PlaylistStatus");
    }


	void Update ()
    {
        if (!audioSource.isPlaying && DankMusic == 0)
        {
            audioSource.clip = GetRandomClipReal();
            audioSource.Play();
            Debug.Log("assff");
        }
        else if (!audioSource.isPlaying && DankMusic == 1)
        {
            audioSource.clip = GetRandomClipAstely();
            audioSource.Play();
        }
	}

    private AudioClip GetRandomClipAstely()
    {

        return RickAstelyPlaylist[Random.Range(0, RickAstelyPlaylist.Length)];

    }


    private AudioClip GetRandomClipReal()
    {

        return RealPlaylist[Random.Range(0, RealPlaylist.Length)];

    }
}
