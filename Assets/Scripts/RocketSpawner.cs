using System.Collections;
using UnityEngine;

public class RocketSpawner : MonoBehaviour
{
    public GameObject rocketPrefab;   // Префаб ракеты
    public GameObject player;         // Ссылка на объект игрока
    public float spawnInterval = 5f;  // Интервал появления ракет

    void Start()
    {
        StartCoroutine(SpawnRockets());
    }

    IEnumerator SpawnRockets()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            // Позиция спавна ракеты за правым краем камеры
            Vector3 spawnPosition = new Vector3(Camera.main.ViewportToWorldPoint(new Vector3(1, 0.5f, 0)).x + 1f, 
                                                player.transform.position.y, 
                                                0);

            // Создаем ракету и присваиваем игрока
            Rocket rocket = Instantiate(rocketPrefab, spawnPosition, Quaternion.identity).GetComponent<Rocket>();
            rocket.player = player;  // Передаем ссылку на игрока в скрипт Rocket
        }
    }
}
