using UnityEngine;

public class RotatingComponent : MonoBehaviour
{
    [SerializeField] private float speed;
    private float value;
    private void Update()
    {
        value += speed * Time.deltaTime;
        transform.SetEulerAnglesY(value);
    }
}
