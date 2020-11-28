using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringPail : MonoBehaviour
{
    [Header("Particle Effects")]
    public GameObject wateringEffect;

    [Header("Bars")]
    public GameObject healthBar;
    public GameObject waterBar;

    private Animator anime;

    private void Start()
    {
        anime = GetComponent<Animator>();

    }
    IEnumerator delayWater()
    {
        yield return new WaitForSeconds(3f);

        wateringEffect.SetActive(false);

        if(gameObject.name == "WateringCan")
        {
            waterBar.GetComponent<Healthbar>().addhealth(20);
        }
        else if(gameObject.name == "pesticide")
        {
            healthBar.GetComponent<Healthbar>().addhealth(20);
        }
        gameObject.transform.parent.gameObject.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plant")
        {
            if (Input.GetMouseButtonUp(0))
            {
                wateringEffect.SetActive(true);

                anime.SetTrigger("Pour");

                StartCoroutine(delayWater());
            }
        }
    }

    public void increaseBar(int points)
    {
        healthBar.GetComponent<Healthbar>().addhealth(points);
    }
}
