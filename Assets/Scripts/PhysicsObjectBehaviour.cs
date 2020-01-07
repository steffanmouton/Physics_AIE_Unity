﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PhysicsObjectBehaviour : MonoBehaviour
{
    public Material awakeMaterial = null;
    public Material sleepingMaterial = null;

    private Rigidbody _rigidbody = null;

    private bool wasSleeping = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (_rigidbody.IsSleeping() && !wasSleeping && sleepingMaterial != null)
        {
            wasSleeping = true;
            GetComponent<MeshRenderer>().material = sleepingMaterial;
        }

        if (!_rigidbody.IsSleeping() && wasSleeping && awakeMaterial != null)
        {
            wasSleeping = false;
            GetComponent<MeshRenderer>().material = awakeMaterial;
        }
    }
}
