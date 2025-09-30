using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private Vector3 direction = Vector3.up;

    private void Update()
    {
        transform.Rotate(direction * speed * Time.deltaTime);
    }
}
