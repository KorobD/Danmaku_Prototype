using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {



    private void Start() {
        GameManager.Instance.OnGamePaused += GameManager_OnGamePaused;
        GameManager.Instance.OnGameUnpaused += GameManager_OnGameUnpaused;
        Hide();
    }

    private void GameManager_OnGameUnpaused() {
        Hide();
    }

    private void GameManager_OnGamePaused() {
        Show();
    }

    private void Show() {
        gameObject.SetActive(true);
    }

    private void Hide() {
        gameObject.SetActive(false);
    }

    public void ContinuePressed() {
        GameManager.Instance.TogglePauseGame();
    }

    public void MainMenuPressed() {
        SceneManager.LoadScene("MainMenu");
    }
}
