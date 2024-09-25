using UnityEngine;

public class MoveAndSpawnTraffic : MonoBehaviour
{
    public float speed = 1.5f;
    public GameObject TrafficRoad;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -13f)
        {
            Instantiate(TrafficRoad, new Vector3(-1.35f, 7.88f, -7), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
