using UnityEngine;
using System.Collections;
using USingleton;

public class LocalizationManager : GameSingleton <LocalizationManager>
{
    protected override void OnCreated ()
    {
        Debug.Log (GetType ().Name + "::OnCreated");
        ExceptionManager.Instance.HandleException ();
    }

    public string GetString ()
    {
        Debug.Log (GetType ().Name + "::GetString");
        return "";
    }
}
