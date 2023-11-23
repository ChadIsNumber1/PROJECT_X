using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_IdleAnimSelect : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger("IdleSelect", Random.Range(0, 2)); //randomly selects a number (0 or 1)
    }

}