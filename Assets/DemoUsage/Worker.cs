using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DecisionMaking.StateMachine;

[RequireComponent(typeof(RootFSM), typeof(BlackboardManager))]
public class Worker : MonoBehaviour
{
    public Player enemy;

    [Header("Worker Attributes")]
    public float visionRange;
    public float attackRange;
    public float speed;

    public Transform targetTs;

    protected bool m_isCarrying;

    [Header("Gizmos")]
    public bool showVision;
    public bool showAttackRange;

    #region Caches

    protected CharacterController m_cc;
    protected RootFSM m_fsm;
    protected BlackboardManager m_bb;

    protected Transform m_ts;
    protected Transform m_enemyTs;

    #endregion Caches

    private void Awake()
    {
        //Get Components
        m_cc = GetComponent<CharacterController>();
        m_fsm = GetComponent<RootFSM>();
        m_bb = GetComponent<BlackboardManager>();
        m_ts = transform;
        m_enemyTs = enemy.transform;
    }

    // Start is called before the first frame update
    private void Start()
    {
        //Start Running FSM
        m_fsm.TurnOn();
    }

    // Update is called once per frame
    private void Update()
    {
        UpdateMove();

        UpdateBlackboardParams();
    }

    private void UpdateMove()
    {
        m_ts.position = Vector3.MoveTowards(m_ts.position, targetTs.position, speed * Time.deltaTime);
    }

    private void UpdateBlackboardParams()
    {
        float distToEmy = Vector3.Distance(m_ts.position, m_enemyTs.position);

        m_bb.SetBool("enemyVisible", enemy.IsVisible);
        m_bb.SetBool("insideVisionRange", distToEmy < visionRange);
        m_bb.SetBool("isCarrying", m_isCarrying);
        m_bb.SetBool("insideAttackRange", distToEmy < attackRange);
    }

    public void OnEnterGoldenMine()
    {
        m_isCarrying = true;
    }

    public void OnReturnHome()
    {
        m_isCarrying = false;
    }

    private void OnDrawGizmos()
    {
        if (showVision)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(transform.position, visionRange);
        }
        if (showAttackRange)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(transform.position, attackRange);
        }
    }
}