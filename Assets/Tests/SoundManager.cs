using UnityEngine;
using USingleton;

public class SoundManager : GameSingleton <SoundManager>
{
    protected override void OnCreated ()
    {
        Debug.Log (GetType ().Name + "::OnCreated");
        LocalizationManager.Instance.GetString ();
    }
}
