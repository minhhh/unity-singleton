using UnityEngine;
using System;
using UnityEngine.Assertions;

public class SimpleSingleton<T> : BaseMonoBehaviour where T : SimpleSingleton<T>
{
    private static T instance;

    public static T Instance {
        get {
            Assert.IsNotNull (instance, "Instance is null. Please call CreateInstance first!");
            return instance;
        }
    }

    public static T CreateInstance ()
    {
        if (instance != null) {
            Assert.IsNull (instance, "Instance is not null. Please call CreateInstance once only");
            return instance;
        }

        GameObject go = new GameObject (typeof(T).Name);
        instance = go.AddComponent<T> ();

        instance.OnCreated ();

        return instance;
    }

    protected virtual void OnDestroy ()
    {
        instance = null;
    }

    protected virtual void OnCreated ()
    {
    }

}
