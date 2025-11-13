
using System;
using UnityEngine;
[CreateAssetMenu(fileName = "State Machine", menuName = "StateMachine/StateMachine")]
public class StateMachine : ScriptableObject
{
    //Know about the currentState
    //Enter and exit states
    public State currentState;
    [SerializeField] private State defaultState;
    public State GetCurrentState() { return currentState; }
    public void SetCurrentState(State newState, DoorMovement door) {
        if (currentState != null) currentState.OnExit(door);

        currentState = newState; 
        currentState.OnEnter(door);
    }

    public void Init(DoorMovement door) {
        SetCurrentState(defaultState, door);
    }
}
