using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private Vector3 direction;

    private void Update()
    {
        transform.Translate(direction * speed);
    }
}
