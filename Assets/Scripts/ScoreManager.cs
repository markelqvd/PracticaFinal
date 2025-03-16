using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Importar TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referencia al texto
    private int score = 0; // Puntos iniciales
    public AudioSource hitSound;

    void Start()
    {
        UpdateScoreText();
        Obstacle.OnObstacleHit += AddPoint; // Suscribirse al evento
    }

    void OnDestroy()
    {
        Obstacle.OnObstacleHit -= AddPoint; // Desuscribirse al evento
    }

    void AddPoint()
    {
        score += 10; // Sumar 10 puntos por obstáculo destruido
        hitSound.Play();
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Puntos: " + score;
    }
}
