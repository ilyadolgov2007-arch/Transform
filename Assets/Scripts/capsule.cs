using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class capsule : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private Vector3 directionScale;
    private void Update()
    {
        transform.localScale += directionScale * speed * Time.deltaTime;
    }
}
