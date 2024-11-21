using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hasbik : MonoBehaviour
{
    Rigidbody2D rb;
    public float forwardSpeed = 4f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(forwardSpeed, rb.velocity.y);

        float leftCamEdge = Camera.main.ViewportToWorldPoint(new Vector3(0, 0.5f, 0)).x;

        if (transform.position.x < leftCamEdge)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player.hp -= 1; 
        }
        if (other.gameObject.CompareTag("Laser"))
        {
            Destroy(gameObject);
            Score.levelScore += 1;
        }
    }
}
