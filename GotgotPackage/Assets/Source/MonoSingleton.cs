using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : Component
{
    public static T instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            DestroyImmediate(gameObject);
            return;
        }

        instance = this as T;
    }
}