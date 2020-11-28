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
            AudioManager.instance.Play("PourWater");
        }
        else if(gameObject.name == "pesticide")
        {
            healthBar.GetComponent<Healthbar>().addhealth(20);
            AudioManager.instance.Play("PourPowder");
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
                if (gameObject.name == "WateringCan")
                {
                    AudioManager.instance.Play("PourWater");
                }
                else if (gameObject.name == "pesticide")
                {
                    AudioManager.instance.Play("Spray");
                }
                else if (gameObject.name == "fertilizer")
                {
                    AudioManager.instance.Play("PourPowder");
                }

                StartCoroutine(delayWater());
            }
        }
    }

    public void increaseBar(int points)
    {
        healthBar.GetComponent<Healthbar>().addhealth(points);
    }
}
