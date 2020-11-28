using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour
{
   public void adjustMusic(float volume)
    {
        AudioManager.instance.adjustMusic(volume);
    }

    public void adjustSounds(float volume)
    {
        AudioManager.instance.adjustSoundeffects(volume);
    }
}
