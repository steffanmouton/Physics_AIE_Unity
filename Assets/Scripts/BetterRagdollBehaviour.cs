using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterRagdollBehaviour : MonoBehaviour
{
    
    public List<Collider> RagdollParts = new List<Collider>();
    private Animator _animator;
    private Collider boxCollider;

    private bool _ragdollOn;
    
    [SerializeField]
    public bool RagdollOn
    {
        get { return _ragdollOn; }
        set { _ragdollOn = value; if(_ragdollOn) {TurnOnRagdoll();} }
    }

    private void Awake()
    {
        SetRagdollParts();
        _animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void SetRagdollParts()
    {
        Collider[] colliders = gameObject.GetComponentsInChildren<Collider>();

        foreach (Collider c in colliders)
        {
            if (c.gameObject != this.gameObject)
            {
                c.isTrigger = true;
                c.attachedRigidbody.isKinematic = true;
            }

            RagdollParts.Add(c);
        }
    }

    public void TurnOnRagdoll()
    {
        _animator.enabled = false;
        boxCollider.enabled = false;
        
        foreach (Collider c in RagdollParts)
        {
            if (c.attachedRigidbody == null)
                continue;
            c.isTrigger = false;
            c.attachedRigidbody.isKinematic = false;
            //c.attachedRigidbody.velocity = Vector3.zero;
        }
    }
}
