using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;  // ������ ������
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
        restartButton.SetActive(false);  // ������ ������ � ������
    }
    void Update()
    {
        if (isDead)
            return;  // �� ������� ���������, ���� �� �����

        // ���������, ���� ���� ������� ��� ���� �����
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPosition = Input.mousePosition;

            // ����������, ��� ����� �����: �� ����� ��� ������ ����� ������
            if (touchPosition.x < Screen.width / 2)
            {
                // �������� �����
                MoveLeft();
            }
            else
            {
                // �������� ������
                MoveRight();
            }
        }
    }

    // ������� ��������
    private void MoveLeft()
    {
        Vector3 dir = new Vector3(-1f, 0f, 0f);  // �������� �����
        transform.Translate(dir.normalized * Time.deltaTime * speed);
    }

    private void MoveRight()
    {
        Vector3 dir = new Vector3(1f, 0f, 0f);  // �������� ������
        transform.Translate(dir.normalized * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)  // ������� ��� ������������
    {
        if (collision.gameObject.CompareTag("Car") || collision.gameObject.CompareTag("Wall"))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            // ������������� ���� ������
            isDead = true;
            
            Destroy(gameObject);  // ���������� ������ ������

            // ������������� �����
            Time.timeScale = 0f;

            // ���������� ������ ��������
            restartButton.SetActive(true); 
        }
    }
}

