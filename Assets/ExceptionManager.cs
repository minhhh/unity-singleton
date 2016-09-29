using UnityEngine;
using System.Collections;

public class ExceptionManager : SimpleSingleton <ExceptionManager>
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
