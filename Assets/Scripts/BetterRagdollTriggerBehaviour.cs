using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterRagdollTriggerBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        BetterRagdollBehaviour ragdoll = other.gameObject.GetComponentInParent<BetterRagdollBehaviour>();

        if (ragdoll != null)
        {
            ragdoll.RagdollOn = true;
        }
    }
}
