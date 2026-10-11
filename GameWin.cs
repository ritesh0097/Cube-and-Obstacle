using UnityEngine;

public class GameWin : MonoBehaviour
{
    [SerializeField] ParticleSystem particleSystem1;
    [SerializeField] ParticleSystem particleSystem2;

    [SerializeField] GameObject gameWinPanel;
    [SerializeField] GameObject gamePauseButton;

    PlayerMovement playerMovement;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WinFlag"))
        {            
            playerMovement.isAlive = false;            
            particleSystem1.Play();
            particleSystem2.Play();
            AudioManager.Instance.WinSound();
            Invoke("GameWinPanelAwake", 1f);
        }
    }

    void GameWinPanelAwake()
    {
        gameWinPanel.SetActive(true);
        gamePauseButton.SetActive(false);
    }
}
