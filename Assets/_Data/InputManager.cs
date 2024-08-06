using UnityEngine;

public class InputManager : GameMonoBehaviour
{
    protected void Update()
    {
        if (Input.GetMouseButtonDown(1)) {
            GridManagerCtrl.Instance.blockHandler.Unchoose();
            BlockDebug.Instance.ClearDebug();
        }
    }
}
