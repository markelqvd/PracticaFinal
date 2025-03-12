using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public AudioSource hitSound;

    void OnEnable()
    {
        Obstacle.OnObstacleHit += HandleObstacleHit;
    }

    void OnDisable()
    {
        Obstacle.OnObstacleHit -= HandleObstacleHit;
    }

    void HandleObstacleHit()
    {
        score += 10;
        hitSound.Play();
        Debug.Log("Puntos: " + score);
    }
}
