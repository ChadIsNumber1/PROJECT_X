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

    public void ChangeState(IState newState, Animator animator)
    {
        if (currentState != null)
            currentState.Exit();

        currentState = newState;
        currentState.Enter(animator);
    }

    public void ChangeState(IState newState, Animator animator, PlayableCharacterType characterType)
    {
        if (currentState != null)
            currentState.Exit();

        currentState = newState;
        currentState.Enter(animator, characterType);
    }

    public void ChangeState(IState newState, Animator animator, PlayableCharacterType characterType, Health health, int damage)
    {
        if (currentState != null)
            currentState.Exit();

        currentState = newState;
        currentState.Enter(animator, characterType, health, damage);
    }
}
