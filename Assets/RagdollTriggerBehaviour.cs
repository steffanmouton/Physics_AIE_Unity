using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollTriggerBehaviour : MonoBehaviour
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
        RagdollBehaviour ragdoll = other.gameObject.GetComponentInParent<RagdollBehaviour>();
        if (ragdoll != null)
        {
            ragdoll.RagdollOn = true;
        }
    }
}
