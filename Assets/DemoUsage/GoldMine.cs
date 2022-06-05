using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldMine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Worker comp;
        if (other.gameObject.TryGetComponent(out comp))
        {
            comp.OnEnterGoldenMine();
        }
    }
}