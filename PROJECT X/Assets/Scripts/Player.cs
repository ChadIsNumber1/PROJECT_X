using projectX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Animator animator;
    [SerializeField] private Health health;
    [Header("States")]
    [SerializeField] private StateMachine stateMachine;
    [SerializeField] private IdleState idleState;
    [SerializeField] private WalkFwdState walkFwdState;
    [SerializeField] private WalkBackState walkBackState;
    [SerializeField] private LightNeutralState lightNeutralState;
    [SerializeField] private LightFwdState lightFwdState;
    [SerializeField] private HitState hitState;
    [Header("Player Info")]
    [SerializeField] private int playerID = 0;
    [SerializeField] private PlayableCharacterType characterType = PlayableCharacterType.NONE;
    [SerializeField] private bool isAttacking = false;
    [SerializeField] private bool isHit = false;
    [SerializeField] private float attackDelay = 0f;
    [SerializeField] private float hitDelay = 0.2f;
    [Header("Other Player Script")] // Shitty solution for now, imagine a static game manager would be used later on
    [SerializeField] private Player otherPlayer;

    void Awake()
    {
        stateMachine = new StateMachine();
        idleState = new IdleState();
        walkFwdState = new WalkFwdState();
        walkBackState = new WalkBackState();
        lightNeutralState = new LightNeutralState();
        lightFwdState = new LightFwdState();
        hitState = new HitState();
    }

    private void Start()
    {
        stateMachine.Init(idleState, animator);
    }

    private void Update()
    {
        Inputs();
    }

    private void Inputs()
    {
        if (playerID == 1)
        {
            InputsP1();
        }
        else if (playerID == 2)
        {
            InputsP2();
        }
        else
        {
            Debug.Log("Incorrect Player ID");
        }
    }

    private void InputsP1()
    {
        if (!isHit)
        {
            // If not hit and not attacking
            if (!isAttacking)
            {
                if (VirtualInputManager.Instance.GetWalkFwdP1())                        // Walk Fwd
                {
                    stateMachine.ChangeState(walkFwdState, animator);
                }
                else if (VirtualInputManager.Instance.GetWalkBackP1())                  // Walk Back
                {
                    stateMachine.ChangeState(walkBackState, animator);
                }
                else
                {
                    stateMachine.ChangeState(idleState, animator);
                }

                if (VirtualInputManager.Instance.GetLightFwdP1())                       // Light Fwd Attack
                {
                    isAttacking = true;
                    stateMachine.ChangeState(lightFwdState, animator, characterType);
                    attackDelay = lightFwdState.GetFrameTime();
                    Invoke("AttackDone", attackDelay);
                }
                else if (VirtualInputManager.Instance.GetLightNeutralP1())              // Light Neutral Attack
                {
                    isAttacking = true;
                    stateMachine.ChangeState(lightNeutralState, animator, characterType);
                    attackDelay = lightNeutralState.GetFrameTime();
                    Invoke("AttackDone", attackDelay);
                }
            }
        }
    }

    private void InputsP2()
    {
        if (!isHit)
        {
            // If not hit and not attacking
            if (!isAttacking)
            {
                if (VirtualInputManager.Instance.GetWalkFwdP2())                        // Walk Fwd
                {
                    stateMachine.ChangeState(walkFwdState, animator);
                }
                else if (VirtualInputManager.Instance.GetWalkBackP2())                  // Walk Back
                {
                    stateMachine.ChangeState(walkBackState, animator);
                }
                else
                {
                    stateMachine.ChangeState(idleState, animator);
                }

                if (VirtualInputManager.Instance.GetLightFwdP2())                       // Light Fwd Attack
                {
                    isAttacking = true;
                    stateMachine.ChangeState(lightFwdState, animator, characterType);
                    attackDelay = lightFwdState.GetFrameTime();
                    Invoke("AttackDone", attackDelay);
                }
                else if (VirtualInputManager.Instance.GetLightNeutralP2())              // Light Neutral Attack
                {
                    isAttacking = true;
                    stateMachine.ChangeState(lightNeutralState, animator, characterType);
                    attackDelay = lightNeutralState.GetFrameTime();
                    Invoke("AttackDone", attackDelay);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CollisionChecks(other.gameObject))
        {
            Debug.Log(other.gameObject.name + " has been hit!");
            isHit = true;
            // Temp damage of 10, damage value should be obtained by colliders gameobj, then its state, and the damage
            stateMachine.ChangeState(hitState, animator, characterType, health, 10);
            hitDelay = hitState.GetFrameTime();
            Invoke("HitDone", hitDelay);
        }

    }

    private void AttackDone()
    {
        isAttacking = false;
    }

    private void HitDone()
    {
        isHit = false;
        stateMachine.ChangeState(idleState, animator);
    }

    public bool GetIsAttacking()
    {
        return isAttacking;
    }


    public bool CollisionChecks(GameObject other)
    {

        // If not self
        if (!other.CompareTag($"Player{playerID}"))
        {
            // If hitbox
            if (other.layer == 8)
            {
                // If they are attacking
                if (otherPlayer.GetIsAttacking())
                {
                    // if statement here needed (Is active hit?)
                    return true;
                }
            }
        }
        return false;
    }
}



