using UnityEngine;

public class ObjectGrow : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Vector3 _directionScale;
    private void Update()
    {
        transform.localScale += _directionScale * _speed * Time.deltaTime;
    }
}
