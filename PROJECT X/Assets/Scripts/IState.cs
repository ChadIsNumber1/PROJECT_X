using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    public void Enter();

    public void Enter(Animator anim);
    public void Update();

    public void FixedUpdate();
    public void Exit();
}
