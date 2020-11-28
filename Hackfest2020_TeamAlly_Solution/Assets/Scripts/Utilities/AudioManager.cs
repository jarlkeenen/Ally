using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sounds[] sounds;
    public static AudioManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        foreach (Sounds s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        Play("Theme");
    }

    public void Play(string name) //function for finding sounds by their name
    {
        Sounds s = Array.Find(sounds, sound => sound.name == name); //looks through sounds in array and chooses the sound with the chosen name
        if (s == null)
        {
            Debug.LogWarning("Sound File " + name + " not found!");
            return; //to avoid errors in case a sound is not found. now the game won't even try to play what doesn't exist
        }
        s.source.Play(); //plays the sound

    }

    public void Pause(string name)
    {
        Sounds s = Array.Find(sounds, sound => sound.name == name); //looks through sounds in array and chooses the sound with the chosen name
        if (s == null)
        {
            Debug.LogWarning("Sound File " + name + " not found!");
            return; //to avoid errors in case a sound is not found. now the game won't even try to play what doesn't exist
        }
        s.source.Pause(); //pauses the sound
    }

    public void Stop(string name)
    {
        Sounds s = Array.Find(sounds, sound => sound.name == name); //looks through sounds in array and chooses the sound with the chosen name
        if (s == null)
        {
            Debug.LogWarning("Sound File " + name + " not found!");
            return; //to avoid errors in case a sound is not found. now the game won't even try to play what doesn't exist
        }
        s.source.Stop(); //stops the sound
    }

    public void adjustMusic(float volume)
    {
        sounds[0].source.volume = volume;
    }

    public void adjustSoundeffects(float volume)
    {
        for(int i = 1; i < sounds.Length; i++)
        {
            if (sounds[i] == null)
            {
                Debug.LogWarning("Sound file: " + sounds[i].name + " not found!");
                return;
            }
            sounds[i].source.volume = volume;
        }
    }
}
