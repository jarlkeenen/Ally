using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waitTodie()
    {
        yield return new WaitForSeconds(2f);

        gameObject.SetActive(false);
    }

    public void Fall()
    {
        rb.gravityScale = 1;

        Debug.Log("gravity scale changed");

        StartCoroutine(waitTodie());
    }    
}
