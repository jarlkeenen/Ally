using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sounds
{
    public string name;

    public AudioClip clip;

    [Range(0f, 1f)] //denotes minimum and maximum value for volume
    public float volume;
    [Range(0f, 1f)] //denotes minimum and maximum value for pitch
    public float pitch;

    public bool loop;

    [HideInInspector] //Hides variable in inspector even tho its public
    public AudioSource source;
}
