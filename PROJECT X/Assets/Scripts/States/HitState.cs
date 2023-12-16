using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitState : IState
{
    private AnimState animationState = AnimState.Hit;
    private PlayableCharacterType playerCharacterType = PlayableCharacterType.NONE;
    private FrameDataSO frameData;
    private float frameTime = 0f;



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
        return;
    }

    public void Enter(Animator animator, PlayableCharacterType characterType, Health health, float damage)
    {
        if (playerCharacterType == PlayableCharacterType.NONE)
        {
            playerCharacterType = characterType;
            if (frameData == null)                      // Loads light-neutral of char used if not already
            {
                frameData = Resources.Load<FrameDataSO>($"FrameData/{characterType}/Hit");
            }
        }

        frameTime = frameData.GetTotalTime();
        animator.Play(animationState.ToString());
        // Damage Portion
        health.ChangeHealth(damage);
    }

    public float GetFrameTime()
    {
        return frameTime;
    }

    public void FixedUpdate()
    {
        return;
    }

    public void Update()
    {
        frameTime = frameTime - Time.deltaTime;
    }

    public void Exit()
    {
        return;
    }


}
