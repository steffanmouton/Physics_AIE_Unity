using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBehaviour : MonoBehaviour
{
    public float explosionForce;
    public float explosionLifetime = 1f;
    public float explosionRadius;
    // Start is called before the first frame update
    void Start()
    {
        explosionRadius = GetComponent<SphereCollider>().radius;
        //Destroy(this.gameObject, explosionLifetime);
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
        
        //other.attachedRigidbody.AddExplosionForce(explosionForce, transform.position,explosionRadius);
    }
}
