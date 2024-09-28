using UnityEngine;
using UnityEditor;

public class MoveAndSpawnBuildings : MonoBehaviour
{
    public float speed = 1.5f;
    public GameObject building;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -10.8f)
        {
            Instantiate(building, new Vector3(0f, 10.58f, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
