using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotifToggleButton : MonoBehaviour
{
    public Slider notifToggle;

    public void notifTogglePressed()
    {
        if (notifToggle.value == 0)
        {
            notifToggle.value = 1;
        }
        else
        {
            notifToggle.value = 0;
        }
    }
}
