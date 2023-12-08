using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    AnimState animationState = AnimState.Idle;

    public virtual void Enter()
    {
        return;
    }

    public void Enter(Animator animator)
    {
        animator.Play(animationState.ToString());
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
