using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public Slider SoundEffects;
    public Slider Music;

    public void Start()
    {
        SoundEffects.value = AudioManager.instance.GetSoundEffectsVolume();
        Music.value = AudioManager.instance.GetMusicVolume();
    }

    public void adjustMusic(float volume)
    {
        AudioManager.instance.adjustMusic(volume);
    }

    public void adjustSounds(float volume)
    {
        AudioManager.instance.adjustSoundeffects(volume);
    }
}
