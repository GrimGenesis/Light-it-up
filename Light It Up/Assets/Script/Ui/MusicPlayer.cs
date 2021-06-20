using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource soundSource;
    private float musicVolume = 1f;
    private float soundVolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        musicSource.Play();
        soundSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        musicSource.volume = musicVolume;
        soundSource.volume = soundVolume;
    }

    public void updateMusic(float mvol)
    {
        musicVolume = mvol;
    }

    public void updateSound(float svol)
    {
        soundVolume = svol;
    }

}
