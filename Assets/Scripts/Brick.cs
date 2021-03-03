using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 initialPosition;
    bool platformMovingBack;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (platformMovingBack)
        {
            transform.position = Vector2.MoveTowards(transform.position, initialPosition, 20f * Time.deltaTime);
        }
        if (transform.position.y == initialPosition.y)
        {
            platformMovingBack = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Equals("Player") && !platformMovingBack)
        {
            Invoke("DropPlatform", 0.5f);
        }
    }

    void DropPlatform()
    {
        rb.isKinematic = false;
        Invoke("GetPlatformBack", 2f);
    }
    
    void GetPlatformBack()
    {
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
        platformMovingBack = true;
    }
}
