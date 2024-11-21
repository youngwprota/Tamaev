using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce = 50;
    public float forwardSpeed = 5;
    public Animator animator;      

    public static int hp = 3;

    public static bool isDead;

    public bool isOnGround = false;

    void Start()
    {
        hp = 3;
        rb = GetComponent<Rigidbody2D>();
        isDead = false;
    }

    void Update()
    {
    if (hp <= 0) {
        if (Score.prefScore >= Score.levelScore) {
            Score.score += Score.levelScore * Score.kf;
        }
        else {
            Score.score -= Score.prefScore;
        }

        isDead = true;
        PlayerPrefs.SetFloat("Score", Score.score); 
        Destroy(gameObject);
        SceneManager.LoadScene("Loose");
    }

    if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);
        }

        rb.velocity = new Vector2(forwardSpeed, rb.velocity.y);

        animator.SetBool("isOnGround", isOnGround);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Edge"))
        {
            isOnGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Edge"))
        {
            isOnGround = false;
        }
    }

}
