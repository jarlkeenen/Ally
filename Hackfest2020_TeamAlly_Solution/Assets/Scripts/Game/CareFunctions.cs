using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CareFunctions : MonoBehaviour
{
    [Header("Care Item Parents")]
    public GameObject wateringPailParent;
    public GameObject fertilizePlantParent;
    public GameObject pesticideParent;

    [Header("Care Items")]
    public GameObject sunSlider;

    [Header("Other")]
    public GameObject spotLight;
    private SpriteRenderer lightOpacity;
    public TextMeshProUGUI opacityLevel;

    // Start is called before the first frame update
    void Start()
    {
        wateringPailParent.SetActive(false);
        sunSlider.SetActive(false);
        fertilizePlantParent.SetActive(false);
        pesticideParent.SetActive(false);

        lightOpacity = spotLight.GetComponent<SpriteRenderer>();
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
        Color tmp = lightOpacity.color;

        tmp.a = opacity;

        lightOpacity.color = tmp;

        opacityLevel.text = Mathf.RoundToInt(opacity * 100) + "%";
    }

    public void sunSliderHide()
    {
        sunSlider.SetActive(false);
    }

    public void fertilizePlant()
    {
        fertilizePlantParent.SetActive(true);
    }

    public void sprayPesticide()
    {
        pesticideParent.SetActive(true);
    }

}
