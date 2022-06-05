using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DecisionMaking.StateMachine;

public class SeekingToMine : WorkerFSMBase
{
    public Transform mine;

    public override void OnEnter()
    {
        base.OnEnter();
        m_entity.targetTs = mine;
    }
}