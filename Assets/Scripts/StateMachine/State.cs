
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "State", menuName = "StateMachine/State")]
public class State : ScriptableObject
{
    public Actions[] onEnterActions;
    public Actions[] onExitActions;
    public void OnEnter(DoorMovement door) {
        foreach (var a in onEnterActions)
            a?.Execute(door);
    }

    public void OnExit(DoorMovement door) {
        foreach (var a in onExitActions)
            a?.Execute(door);
    }
}
