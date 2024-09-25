using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    void Start()
    {
        // ¬ключаем музыку при старте игры
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    public void StopMusic()
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }

    public void PlayMusic()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}