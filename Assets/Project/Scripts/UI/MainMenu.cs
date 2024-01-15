using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void PlayPressed() {
        SceneManager.LoadScene("TestStage");
    }

    public void ExitPressed() {
        UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
    }

    private void Awake() {
        Time.timeScale = 1.0f;
    }
}
