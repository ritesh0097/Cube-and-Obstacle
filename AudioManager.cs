using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Audio Sources")]    
    [SerializeField] AudioSource sfxSource;

    [Header("Audio Clips")]    
    [SerializeField] AudioClip jumpSound;    
    [SerializeField] AudioClip obstacleHitSound;
    [SerializeField] AudioClip winSound;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }


    public void JumpSound()
    {
        sfxSource.PlayOneShot(jumpSound);
    }
        
    public void ObstacleHitSound()
    {
        sfxSource.PlayOneShot(obstacleHitSound);
    }

    public void WinSound()
    {
        sfxSource.PlayOneShot(winSound);
    }


}