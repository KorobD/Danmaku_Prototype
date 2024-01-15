using System;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance { get; private set; }

    public Action OnGamePaused;
    public Action OnGameUnpaused;
    public Action OnGameEnd;

    private bool isGamePause = false;


    private void Awake() {
        Time.timeScale = 1f;
    }

    private void Start() {
        Instance = this;
        GameInput.Instance.OnPauseAction += GameInput_OnpauseAction;
        SpawnerTestStage.Instance.OnEndSpawn += SpawnerTestStage_OnEndSpawn;
        Player.OnPlayerDestroy += SpawnerTestStage_OnEndSpawn;
    }

    private void SpawnerTestStage_OnEndSpawn() {
        OnGameEnd?.Invoke();
        Time.timeScale = 0f;
    }

    private void GameInput_OnpauseAction() {
        TogglePauseGame();
    }

    private void OnDestroy() {
        GameInput.Instance.OnPauseAction -= GameInput_OnpauseAction;
    }

    public void TogglePauseGame() {
        isGamePause = !isGamePause;
        if (isGamePause) {
            Time.timeScale = 0f;
            OnGamePaused?.Invoke();
        } else {
            Time.timeScale = 1f;
            OnGameUnpaused?.Invoke();
        }
            
    }

}
