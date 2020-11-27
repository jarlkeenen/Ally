using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CareFunctions : MonoBehaviour
{
    [Header("Care Item Parents")]
    public GameObject wateringPailParent;
    public GameObject fertilizePlantParent;

    [Header("Care Items")]
    public GameObject sunSlider;

    [Header("Other")]
    public GameObject spotLight;

    // Start is called before the first frame update
    void Start()
    {
        wateringPailParent.SetActive(false);
        sunSlider.SetActive(false);
        fertilizePlantParent.SetActive(false);
    }

    public void waterPlant()
    {
        wateringPailParent.SetActive(true);      
    }

    public void sunSliderShow()
    {
        sunSlider.SetActive(true);
    }

    public void adjustLight(float opacity)
    {
        spotLight.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, -opacity);
        Debug.Log(opacity);
    }

    public void sunSliderHide()
    {
        sunSlider.SetActive(false);
    }

    public void fertilizePlant()
    {
        fertilizePlantParent.SetActive(true);
    }
}
