using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;  // ������ ������

    public float speed = 2f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)  // ������� ��� ������������
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            // ������� ����� � ������� ������
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            // ���������� ������ ������
            Destroy(gameObject);
        }
    }
}
