using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    private Slider slider; 


    public void addhealth(int health)
    {
        slider.value += health;
    }
    //adjust health
    public void setHealth(int health)
    {
        slider.value = health;
    }

    //set max health through script
    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
