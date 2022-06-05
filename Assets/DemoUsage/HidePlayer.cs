using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player enteringPlayer;
        if (other.gameObject.TryGetComponent(out enteringPlayer))
            enteringPlayer.OnHidePlayer(false);
    }

    private void OnTriggerExit(Collider other)
    {
        Player enteringPlayer;
        if (other.gameObject.TryGetComponent(out enteringPlayer))
            enteringPlayer.OnHidePlayer(true);
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}