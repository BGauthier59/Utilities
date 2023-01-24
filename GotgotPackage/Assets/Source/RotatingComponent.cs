using UnityEngine;

public class RotatingComponent : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 rotation;
    private void Update()
    {
        transform.Rotate(rotation * (speed * Time.deltaTime));
    }
}
