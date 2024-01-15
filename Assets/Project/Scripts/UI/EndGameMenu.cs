using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour {


    private void Start() {
        GameManager.Instance.OnGameEnd = GameManager_OnGameEnd;
        Hide();
    }

    private void GameManager_OnGameEnd() {
        Show();
    }

    private void Show() {
        gameObject.SetActive(true);
    }

    private void Hide() {
        gameObject.SetActive(false);
    }

    public void RestartPressed() {
        SceneManager.LoadScene("TestStage");
    }

    public void MainMenuPressed() {
        SceneManager.LoadScene("MainMenu");
    }
}
