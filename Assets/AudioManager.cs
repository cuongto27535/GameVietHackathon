using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic("Theme");
    }

    public void PlayMusic(String name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);
        if (s==null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            musicSource.clip = s.Clip;
            musicSource.Play();
        }
    }
    public void PlaySFX(String name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);
        if (s==null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
           sfxSource.PlayOneShot(s.Clip);
        }
    }
}
