﻿using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{

    void Start ()
    {
        ExceptionManager.CreateInstance ();
        LocalizationManager.CreateInstance ();
        SoundManager.CreateInstance ();
        SceneManager.Instance.SomeMethod ();
    }

    public void DestroySingletons ()
    {
        Destroy (ExceptionManager.Instance.gameObject);
        Destroy (LocalizationManager.Instance.gameObject);
        Destroy (SoundManager.Instance.gameObject);
    }

}
