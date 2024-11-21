using System.Collections;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    public GameObject laserPrefab;   
    private GameObject currentLaser; 
    public Transform gunPosition;    
    public Player player;      

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !player.isOnGround)
        {
            if (currentLaser == null)
            {
                currentLaser = Instantiate(laserPrefab, gunPosition.position, Quaternion.Euler(0, 0, 90));
                currentLaser.transform.parent = gunPosition;
            }
        }
        else
        {
            if (currentLaser != null)
            {
                Destroy(currentLaser);
            }
        }
    }
}
