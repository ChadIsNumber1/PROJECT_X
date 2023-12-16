using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    public void Enter();

    public void Enter(Animator animator);

    public void Enter(Animator animator, PlayableCharacterType characterType);

    public void Enter(Animator animator, PlayableCharacterType characterType, Health health, float damage);
    public void Update();

    public void FixedUpdate();
    public void Exit();
}
