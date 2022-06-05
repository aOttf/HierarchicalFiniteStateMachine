using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DecisionMaking.StateMachine;

public class Player : MonoBehaviour
{
    protected bool m_isVisible;
    public bool IsVisible => m_isVisible;

    public void OnHidePlayer(bool hide) => m_isVisible = hide;
}