using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringPail : MonoBehaviour
{
    [Header("Particle Effects")]
    public GameObject wateringEffect;

    private Animator anime;
    private Collider2D discollider;


    private void Start()
    {
        anime = GetComponent<Animator>();
        discollider = GetComponent<BoxCollider2D>();
    }
    IEnumerator delayWater()
    {
        yield return new WaitForSeconds(3f);

        wateringEffect.SetActive(false);
        gameObject.transform.parent.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
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
}
