using UnityEngine;
using UnityEngine.UI;

public class DoorController : MonoBehaviour{
    [SerializeField] Button OpenClose;
    [SerializeField] StateMachine stateMachine;
    [SerializeField] State openState;
    [SerializeField] State closeState;
    [SerializeField] State isClosingState;
    [SerializeField] State isOpeningState;
    [SerializeField] DoorMovement doorMovement;
    private void Start() {
        stateMachine.Init(doorMovement);
        OpenClose.onClick.AddListener(ToggleDoor);
    }
    private void OnDisable() {
        OpenClose.onClick.RemoveListener(ToggleDoor);
    }
    
    private void ToggleDoor() {
        // Lógica simple de toggle
        if (stateMachine.GetCurrentState() == openState)
        {
            stateMachine.SetCurrentState(isClosingState, doorMovement);
            stateMachine.SetCurrentState(closeState, doorMovement);
        }
        else
        {
            stateMachine.SetCurrentState(isOpeningState, doorMovement);
            stateMachine.SetCurrentState(openState, doorMovement);
        }

    }
}
