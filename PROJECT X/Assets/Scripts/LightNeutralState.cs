using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightNeutralState : IState
{
    private AnimState animationState = AnimState.LightNeutral;
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
        if (playerCharacterType == PlayableCharacterType.NONE)
        {
            playerCharacterType = characterType;
            if (frameData == null)                      // Loads light-neutral of char used if not already
            {
                frameData = Resources.Load<FrameDataSO>($"FrameData/{characterType}/LightNeutral");
            }
        }
        frameTime = frameData.GetTotalTime();
        animator.Play(animationState.ToString());
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

    public void Enter(Animator animator, PlayableCharacterType characterType, Health health, int damage)
    {
        throw new System.NotImplementedException();
    }
}
