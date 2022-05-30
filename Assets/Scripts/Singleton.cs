using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : Component
{
    private static T _instance = null;

    public static T Instance
    {
        get
        {
            if (!_instance)
            {
                Debug.LogException(new System.Exception($"{nameof(Singleton<T>)} with type {nameof(T)} is null"));
            }

            return _instance;
        }
    }

    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
