using UnityEngine;

[CreateAssetMenu(fileName ="DebugMessage",menuName = "StateMachine/Actions/Debug Message")]
public class DebugAction : Actions {
    public string message;

    public override void Execute(DoorMovement door) {
        Debug.Log(message);
    }
}
