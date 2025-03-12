using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Obstacle : MonoBehaviour
{
    public static event Action OnObstacleHit;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            OnObstacleHit?.Invoke(); // Llama al evento para sumar puntos
            Destroy(gameObject); // Destruye el obstáculo
        }
    }
}
