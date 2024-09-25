using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // ����� ��� ����������� ����
    public void RestartGame()
    {
        Time.timeScale = 1f; // ��������������� ����������� ������� �������
        SceneManager.LoadScene(1); // ��������� ����� ������
    }
}
