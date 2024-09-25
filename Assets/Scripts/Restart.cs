using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Метод для перезапуска игры
    public void RestartGame()
    {
        Time.timeScale = 1f; // Восстанавливаем стандартное течение времени
        SceneManager.LoadScene(1); // Загружаем сцену заново
    }
}
