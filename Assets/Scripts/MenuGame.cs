using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGame : MonoBehaviour
{
    public void Play() => SceneManager.LoadScene(1);

    public void Quite() => Application.Quit();

}
