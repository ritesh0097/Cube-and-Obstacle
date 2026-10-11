using UnityEngine;

public class GameOver : MonoBehaviour
{

    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameObject gamePauseButton;

    PlayerMovement playerMovement;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Hazards"))
        {
            AudioManager.Instance.ObstacleHitSound();
            Invoke("GameOverAwake", 0.5f);
        }
    }

    void GameOverAwake()
    {
        playerMovement.isAlive = false;
            gameOverPanel.SetActive(true);
            gamePauseButton.SetActive(false);
    }
}