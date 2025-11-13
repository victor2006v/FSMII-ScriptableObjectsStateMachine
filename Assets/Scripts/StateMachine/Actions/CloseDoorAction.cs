
using UnityEngine;

[CreateAssetMenu(fileName = "CloseDoor", menuName = "StateMachine/Actions/Close Door")]
public class CloseDoorAction : Actions {
    public DoorMovement door;

    public override void Execute(DoorMovement door) {
        if (door != null)
            door.Close();
    }
}
