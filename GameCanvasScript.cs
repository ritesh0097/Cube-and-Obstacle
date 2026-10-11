using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCanvasScript : MonoBehaviour
{

    [SerializeField] GameObject gameStartPanel;
    [SerializeField] GameObject gamePausePanel;
    [SerializeField] GameObject gamePauseButton;

    void Awake()
    {
        Time.timeScale = 0;
    }

    public void GameStart()
    {
        Time.timeScale = 1;
        gameStartPanel.SetActive(false);
        gamePauseButton.SetActive(true);
    }
    public void GamePause()
    {
        Time.timeScale = 0;
        gamePausePanel.SetActive(true);
        gamePauseButton.SetActive(false);
    }
    public void GameContinue()
    {
        Time.timeScale = 1;
        gamePausePanel.SetActive(false);
        gamePauseButton.SetActive(true);
    }
    
    public void GameRestart()
    {
        Time.timeScale = 1;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
    
    public void GameExit()
    {
        Application.Quit();
    }
}
