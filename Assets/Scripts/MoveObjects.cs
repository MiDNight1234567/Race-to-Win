using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;  // Префаб взрыва

    public float speed = 2f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)  // Событие при столкновении
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            // Спавним взрыв в позиции игрока
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            // Уничтожаем объект игрока
            Destroy(gameObject);
        }
    }
}
