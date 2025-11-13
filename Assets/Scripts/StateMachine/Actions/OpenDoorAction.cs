using UnityEngine;

[CreateAssetMenu(fileName = "OpenDoor", menuName = "StateMachine/Actions/Open Door")]
public class OpenDoorAction : Actions {
    public DoorMovement door;

    public override void Execute(DoorMovement door) {
        if (door != null)
            door.Open();
    }
}
