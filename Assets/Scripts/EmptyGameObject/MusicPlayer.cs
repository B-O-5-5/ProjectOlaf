using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

    public AudioClip[] clips;
    private AudioSource audioSource;

    void Start ()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
        audioSource.volume = PlayerPrefs.GetFloat("MusicVolume");

    }


	void Update ()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
        }
	}

    private AudioClip GetRandomClip()
    {

        return clips[Random.Range(0, clips.Length)];

    }
}
