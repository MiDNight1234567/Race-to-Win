using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;  // Префаб взрыва
    public GameObject restartButton;
    public float speed = 3f;
    internal bool isDead = false;

    //void Update()
    //{
    //    float hor = Input.GetAxisRaw("Horizontal");
    //    Vector3 dir = new Vector3(hor, 0, 0);
    //    transform.Translate(dir.normalized * Time.deltaTime * speed);
    //}
    void Start()
    {
        restartButton.SetActive(false);  // Скрыть кнопку в начале
    }
    void Update()
    {
        if (isDead)
            return;  // Не двигать персонажа, если он мертв

        // Проверяем, если есть касание или клик мышью
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPosition = Input.mousePosition;

            // Определяем, где нажал игрок: на левой или правой части экрана
            if (touchPosition.x < Screen.width / 2)
            {
                // Движение влево
                MoveLeft();
            }
            else
            {
                // Движение вправо
                MoveRight();
            }
        }
    }

    // Функции движения
    private void MoveLeft()
    {
        Vector3 dir = new Vector3(-1f, 0f, 0f);  // Движение влево
        transform.Translate(dir.normalized * Time.deltaTime * speed);
    }

    private void MoveRight()
    {
        Vector3 dir = new Vector3(1f, 0f, 0f);  // Движение вправо
        transform.Translate(dir.normalized * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)  // Событие при столкновении
    {
        if (collision.gameObject.CompareTag("Car") || collision.gameObject.CompareTag("Wall"))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            // Устанавливаем флаг смерти
            isDead = true;
            
            Destroy(gameObject);  // Уничтожаем объект игрока

            // Останавливаем время
            Time.timeScale = 0f;

            // Показываем кнопку рестарта
            restartButton.SetActive(true); 
        }
    }
}

