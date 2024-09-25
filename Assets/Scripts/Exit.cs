using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public void Play() => SceneManager.LoadScene(0);

    public void Quite() => Application.Quit();
}
