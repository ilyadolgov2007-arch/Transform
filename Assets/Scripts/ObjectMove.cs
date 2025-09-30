using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Vector3 _direction;

    private void Update()
    {
        transform.Translate(_direction * _speed);
    }
}
