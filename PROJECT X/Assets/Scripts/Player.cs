using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Animator animator;
    [Header("States")]
    [SerializeField] private StateMachine stateMachine;
    [SerializeField] private IdleState idleState;

    void Awake()
    {
        stateMachine = new StateMachine();
        idleState = new IdleState();
    }

    private void Start()
    {
        stateMachine.Init(idleState);
    }
}
