using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shears : MonoBehaviour
{
    private Animator anime;
    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            StartCoroutine(waitTodie());
        }
    }

    IEnumerator waitTodie()
    {
        yield return new WaitForSeconds(1f);

        gameObject.transform.parent.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fruit")
        {
            anime.SetTrigger("Cut");   
            collision.GetComponent<Fruit>().Fall();
        }
    }
}
