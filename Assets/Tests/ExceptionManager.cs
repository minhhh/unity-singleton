using UnityEngine;
using System.Collections;
using USingleton;

public class ExceptionManager : GameSingleton <ExceptionManager>
{
    protected override void OnCreated ()
    {
        Debug.Log (GetType ().Name + "::OnCreated");
    }

    public void HandleException ()
    {
        Debug.Log (GetType ().Name + "::HandleException");
    }
}
