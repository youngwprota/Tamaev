using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasbikSpawner : MonoBehaviour
{

    public GameObject hasbik;                
    public float minSpawnInterval = 3f;     
    public float maxSpawnInterval = 7f;      
    public float yOffset = 2f;        

    void Start()
    {
        StartCoroutine(SpawnHasbik());
        
    }

    IEnumerator SpawnHasbik()
    {
        while (true)
        {
            float waitTime = Random.Range(minSpawnInterval, maxSpawnInterval);
            yield return new WaitForSeconds(waitTime);

            float rightCamEdge = Camera.main.ViewportToWorldPoint(new Vector3(1, 0.5f, 0)).x;

            Vector2 spawnPosition = new Vector2(rightCamEdge, -2.62f);
            Instantiate(hasbik, spawnPosition, Quaternion.identity);
        }
    }

}

