using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragToMove : MonoBehaviour
{
    private Vector3 mousePosition;
    private Rigidbody2D rb2d;
    private Vector2 direction;

    [Header("Movement")]
    public float moveSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, -8f));
            direction = (mousePosition - transform.position).normalized;
            rb2d.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
        }
        else
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
