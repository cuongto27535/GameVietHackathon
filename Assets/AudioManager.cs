using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public Sound[] MusicSounds, SfxSounds;
    public AudioSource MusicSource, SfxSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            //adc
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMustic("Theme");
    }


    public void PlayMustic(string name)
    {
        Sound s = Array.Find(MusicSounds, x => x.name == name);

        if (s==null)
        {
            Debug.Log("Sound hot Found");
        }
        else
        {
            MusicSource.clip = s.Clip;
            MusicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(SfxSounds, x => x.name == name);

        if (s==null)
        {
            Debug.Log("Sound hot Found");
        }
        else
        {
            SfxSource.PlayOneShot(SfxSource.clip);
        }
    }
}