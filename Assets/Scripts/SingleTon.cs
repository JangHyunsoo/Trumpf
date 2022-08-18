using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTon<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance_ = null;
    public static T instance
    {
        get
        {
            if (instance_)
            {
                instance_ = FindObjectOfType<T>();
            }
            return instance_;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
