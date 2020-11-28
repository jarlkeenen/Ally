using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shears : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
            collision.GetComponent<Fruit>().Fall();
        }
    }
}
