using UnityEngine;

public class ObjectSpin : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Vector3 _direction = Vector3.up;

    private void Update()
    {
        transform.Rotate(_direction * _speed * Time.deltaTime);
    }
}
