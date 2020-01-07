using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Animator))]
public class PlayerBehaviour : MonoBehaviour
{
    private CharacterController controller = null;
    private Animator animator = null;

    public float speed = 80.0f;
    public float pushPower = 2.0f;
    public float sprintMultiplier = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 70;
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        
        // Used to check vertical axis input val
        //Debug.Log(vertical);

        //controller.SimpleMove(Time.deltaTime * vertical * speed * transform.forward);
        if (Input.GetKey(KeyCode.LeftShift))
            vertical *= sprintMultiplier;
        
        controller.SimpleMove(transform.up * Time.deltaTime);
        transform.Rotate(transform.up, horizontal * speed * Time.deltaTime);
        animator.SetFloat("Speed", vertical * speed * Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic)
            return;

        if (hit.moveDirection.y < -0.3f)
            return;
        
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        body.velocity = pushDir * pushPower;
    }
}
