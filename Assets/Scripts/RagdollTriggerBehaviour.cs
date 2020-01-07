using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollTriggerBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        RagdollBehaviour ragdoll = other.gameObject.GetComponentInParent<RagdollBehaviour>();
        if (ragdoll != null)
        {
            ragdoll.RagdollOn = true;
        }
    }
}
