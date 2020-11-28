using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GardenName : MonoBehaviour
{
    public TextMeshProUGUI gardenName;

    // Start is called before the first frame update
    void Start()
    {
        gardenName.text = PlantDataHandler.instance.gardenName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
