using UnityEngine;

public class ExplosionToPlayer : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;

    private Camera miniCamera;

    private void Start()
    {
        miniCamera = Camera.main;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = miniCamera.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f;
            var explosion = Instantiate(explosionPrefab, mousePosition, Quaternion.identity);
            Destroy(explosion, 1f);
        }
    }
}
