using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RagdollBehaviour : MonoBehaviour
{

    private Animator animator = null;

    public List<Rigidbody> Rigidbodies = new List<Rigidbody>();

    public bool RagdollOn
    {
        get { return !animator.enabled; }
        set
        {
            animator.enabled = !value;
            foreach (Rigidbody r in Rigidbodies)
                r.isKinematic = !value;

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Rigidbodies = GetComponentsInChildren<Rigidbody>().ToList();
        
        animator = GetComponent<Animator>();
        foreach (Rigidbody r in Rigidbodies)
        {
            r.isKinematic = true;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
