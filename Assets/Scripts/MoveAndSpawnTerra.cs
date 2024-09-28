using UnityEngine;

public class MoveAndSpawnTerra : MonoBehaviour
{
    public float speed = 1.5f;
    public GameObject grees;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -20f)
        {
            Instantiate(grees, new Vector3(0f, 20f, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
