using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Unity;
using UnityEngine;

using DecisionMaking.StateMachine;
using System.Collections;

public abstract class WorkerFSMBase : FSMBase
{
    protected Worker m_entity;

    protected override void Awake()
    {
        base.Awake();
        m_entity = GetComponent<Worker>();
    }
}

public class Battling : WorkerFSMBase
{
    protected override void Awake()
    {
        base.Awake();
    }

    public override void OnEnter()
    {
        base.OnEnter();
        m_entity.targetTs = m_entity.enemy.transform;
    }
}