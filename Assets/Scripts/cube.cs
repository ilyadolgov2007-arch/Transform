using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class cub : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private Vector3 direction = Vector3.up;

    private void Update()
    {
        transform.Rotate(direction * speed * Time.deltaTime);
    }
}
