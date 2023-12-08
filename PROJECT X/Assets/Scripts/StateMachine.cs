using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    public IState currentState;

    public void Init(IState startState)
    {
        currentState = startState;
        currentState.Enter();
    }

    public void Init(IState startState, Animator animator)
    {
        currentState = startState;
        currentState.Enter(animator);
    }

    public void ChangeState(IState newState)
    {
        if (currentState != null)
            currentState.Exit();

        currentState = newState;
        currentState.Enter();
    }
}
