using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DecisionMaking.StateMachine;

public class TestBehaviour : FSMBase
{
    public int id;

    public override void OnEnter()
    {
        print("Entering " + id);
    }

    public override void OnUpdate()
    {
        print("Updating " + id);
    }

    public override void OnExit()
    {
        print("Exiting " + id);
    }
}