using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;         
    public float offsetX = 5f;        
    public float smoothSpeed = 0.125f; 

    void LateUpdate()
    {
        if (!Player.isDead) {
            Vector3 desiredPosition = new Vector3(player.position.x + offsetX, transform.position.y, transform.position.z);
            
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            
            transform.position = smoothedPosition;
        }
    }
}
