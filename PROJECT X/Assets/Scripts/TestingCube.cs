using projectX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingCube : MonoBehaviour
{

    [SerializeField] private float movementSpeed;
    [Header("Animations")]
    [SerializeField] private Animator animator;
    [SerializeField] private AnimState curMoveState;
    [SerializeField] private AnimState curAttkState;
    [SerializeField] private bool isLocked;
    [SerializeField] private bool isAttacking;

    void Update()
    {
        MovementInputChecks();

        // Light Attack to the right
        if (VirtualInputManager.Instance.GetLightRight()
            && !isAttacking
            && curAttkState == AnimState.Idle)
        {
            ChangeAnimationState(AnimState.LightRight, true);
            isAttacking = true;
        }



    }


    void ChangeAnimationState(AnimState newState,bool isAttack)
    {
        if (!isAttack)
        {
            if (curMoveState == newState) return;
            animator.CrossFade(newState.ToString(), 0.25f, 0);
            curMoveState = newState;
        }
        else
        {
            if (curAttkState == newState) return;
            animator.CrossFade(newState.ToString(), 0.25f, 1);
            curAttkState = newState;
        }

    }

    void AttackDone()
    {
        if (isAttacking)
        {
            curAttkState = AnimState.Idle;
            isAttacking = false;
        }
    }

    void MovementInputChecks()
    {
        // Char Stays Put if both or none
        if (VirtualInputManager.Instance.GetMoveRight() && VirtualInputManager.Instance.GetMoveLeft() ||
           !VirtualInputManager.Instance.GetMoveRight() && !VirtualInputManager.Instance.GetMoveLeft())
        {
            ChangeAnimationState(AnimState.Idle,false);
        }
        else if (VirtualInputManager.Instance.GetMoveRight())
        {
            this.gameObject.transform.Translate(Vector3.right * movementSpeed * Time.deltaTime); 
            ChangeAnimationState(AnimState.WalkRight, false);

        }
        else if (VirtualInputManager.Instance.GetMoveLeft())
        {
            this.gameObject.transform.Translate(-Vector3.right * movementSpeed * Time.deltaTime);
            ChangeAnimationState(AnimState.WalkLeft, false);
        }
    }
}
