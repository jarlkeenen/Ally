using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GardenNameSetter : MonoBehaviour
{
    public TMP_InputField input;
    public string gardenName;

    public void sendGardenName()
    {
        PlantDataHandler.instance.gardenName = gardenName;
    }
    public void setGardenName()
    {
        gardenName = input.text;

        sendGardenName();
    }
}
