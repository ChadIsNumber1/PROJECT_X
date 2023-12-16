using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    private AnimState animationState = AnimState.Idle;

    public virtual void Enter()
    {
        return;
    }

    public void Enter(Animator animator)
    {
        animator.Play(animationState.ToString());
    }

    public void Enter(Animator animator, PlayableCharacterType characterType)
    {
        throw new System.NotImplementedException();
    }

    public void Enter(Animator animator, PlayableCharacterType characterType, Health health, int damage)
    {
        throw new System.NotImplementedException();
    }

    public void Exit()
    {
        return;
    }

    public void FixedUpdate()
    {
        return;
    }


    public void Update()
    {
        return;
    }
}