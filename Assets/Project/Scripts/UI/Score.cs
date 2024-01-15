using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour {

    private int score = 0;
    [SerializeField] private TMP_Text scoreText;

    private void Awake() {
        Enemy.OnEnemyDestroy += enemy_onEnemyDestroy;
    }

    private void enemy_onEnemyDestroy() {
        AddScore();
    }

    private void AddScore() {
        score++;
        scoreText.text = score.ToString();
    }
}
