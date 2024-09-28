using TMPro;
using UnityEngine;

public class PlayerSpeedDisplay : MonoBehaviour
{
    public TextMeshProUGUI distanceText;  // Текст для отображения пройденных километров
    public float roadSpeed = 1.5f; // Скорость движения трассы в км/ч

    private float distanceTravelled = 0f;  // Пройденное расстояние в километрах

    void Update()
    {
        distanceTravelled += roadSpeed * Time.deltaTime;  // Переводим в километры
        distanceText.text = "Distance:" + Mathf.Round(distanceTravelled) + "m";
    }
}