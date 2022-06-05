using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Unity;
using UnityEngine;

public class Home : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Worker comp;
        if (other.gameObject.TryGetComponent(out comp))
        {
            comp.OnReturnHome();
        }
    }
}