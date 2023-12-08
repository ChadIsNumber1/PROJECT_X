using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkFwdState : IState
{
    AnimState animationState = AnimState.WalkFwd;

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
