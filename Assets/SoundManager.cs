using UnityEngine;
using System.Collections;

public class SoundManager : SimpleSingleton <SoundManager>
{
    protected override void OnCreated ()
    {
        Debug.Log (GetType ().Name + "::OnCreated");
        LocalizationManager.Instance.GetString ();
    }
}
