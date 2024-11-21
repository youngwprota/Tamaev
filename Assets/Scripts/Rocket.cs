using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rocket : MonoBehaviour
{
    public GameObject player;         
    public float observeTime = 2f;      
    public float speed = 10f;            
    public float offsetFromRightEdge = 1f; 

    private bool isLaunched = false;    

    void Start()
    {
        StartCoroutine(ObservePlayer());
    }

    void Update()
    {
        float rightCamEdge = Camera.main.ViewportToWorldPoint(new Vector3(1, 0.5f, 0)).x - offsetFromRightEdge;
        float leftCamEdge = Camera.main.ViewportToWorldPoint(new Vector3(0, 0.5f, 0)).x; 

        if (isLaunched)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            
            if (transform.position.x < leftCamEdge)
            {
                Destroy(gameObject);
            }
        }
        else
        {   
            if (!Player.isDead)
            {
                transform.position = new Vector2(rightCamEdge, player.transform.position.y);
            }
        }
    }

    IEnumerator ObservePlayer()
    {
        yield return new WaitForSeconds(observeTime);
        isLaunched = true;
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Player"))  
        {
            if (Score.prefScore >= Score.levelScore) 
            {
                Score.score += Score.levelScore * Score.kf;
            }
            else 
            {
                Score.score -= Score.prefScore;
            }

            Player.isDead = true;
            PlayerPrefs.SetFloat("Score", Score.score); 
            Destroy(gameObject);
            SceneManager.LoadScene("Loose");
        }
    }

}
