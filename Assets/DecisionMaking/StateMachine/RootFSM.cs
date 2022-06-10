using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Unity;
using UnityEngine;
using UnityEditor;

namespace DecisionMaking.StateMachine
{
    public class RootFSM : FSM
    {
        //public UpdateMode mode = UpdateMode.Update;

        //[Tooltip("how often the state machine executes in seconds")]
        //[SerializeField] protected float m_executionTimeStep = .02f;

        //protected bool m_isRunning;

        [Tooltip("Is the Root FSM turned on")]
        public bool isTurnedOn = false;

        [Header("Gizmos")]
        public bool showState;

        protected override void Awake()
        {
            base.Awake();
        }

        /// <summary>
        /// Turn on the Root FSM and enter it. Root FSM already turned on won't re-enter.
        /// </summary>
        public void TurnOn()
        {
            //Dont enter twice
            if (!isTurnedOn)
            {
                isTurnedOn = true;
                OnEnter();
            }

            //if (!m_isRunning)
            //{
            //    //Reset Current State to the initial one if configured
            //    if (m_resetCurrentState)
            //        m_curState = m_initialState;

            //    //Entering the Root FSM
            //    OnEnter();

            //    StartCoroutine(nameof(StateMachineRoutine));
            //    m_isRunning = true;
            //}
        }

        /// <summary>
        /// Turn off the Root FSM and exit it. Root FSM already turned off won't re-exit.
        /// </summary>
        public void TurnOff()
        {
            //Dont exit twice
            if (!isTurnedOn)
            {
                isTurnedOn = false;
                OnExit();
            }

            //if (m_isRunning)
            //{
            //    StopCoroutine(nameof(StateMachineRoutine));
            //    m_isRunning = false;

            //    //Exiting the Root FSM
            //    OnExit();
            //}
        }

        /// <summary>
        /// Main Executing Loop of the Finite State Machine
        /// </summary>
        /// <returns></returns>
        //private IEnumerator StateMachineRoutine()
        //{
        //    while (true)
        //    {
        //        OnUpdate();

        //        switch (mode)
        //        {
        //            case UpdateMode.Update:
        //                yield return null;
        //                break;

        //            case UpdateMode.FixedUpdate:
        //                yield return new WaitForFixedUpdate();
        //                break;

        //            case UpdateMode.TimeStep:
        //                yield return new WaitForSeconds(m_executionTimeStep);
        //                break;
        //        }
        //    }
        //}

        private void OnDrawGizmos()
        {
            if (showState && Application.isPlaying)
            {
                Handles.Label(transform.position, ToString());
            }
        }
    }
}