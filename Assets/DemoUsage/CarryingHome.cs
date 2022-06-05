using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DecisionMaking.StateMachine;

public class CarryingHome : WorkerFSMBase
{
    public Transform home;

    public override void OnEnter()
    {
        base.OnEnter();
        m_entity.targetTs = home;
    }
}