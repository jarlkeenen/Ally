using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CareFunctions : MonoBehaviour
{
    [Header("Care Item Parents")]
    public GameObject wateringPailParent;

    [Header("Care Items")]
    public GameObject wateringPail;

    // Start is called before the first frame update
    void Start()
    {
        wateringPailParent.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void waterPlant()
    {
        wateringPailParent.SetActive(true);      
    }
}
