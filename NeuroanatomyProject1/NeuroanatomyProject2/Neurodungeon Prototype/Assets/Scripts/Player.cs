﻿using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedJoystick joyStick1;
    
    public float PlayerSpeed;
    public Animator m_animator;

    public Rigidbody rb;

    public GameObject rotatable;

    public PopUpController pUController;
    
    void Start()
    {
        //Sets up components
        rb = GetComponent<Rigidbody>();
        m_animator = GetComponent<Animator>();
        m_animator.SetBool("run", false);
    }

    void Update()
    {
    //Sound effects for footsteps should be added as animation events
        //Sets up physics
        rb.velocity = new Vector3(joyStick1.Horizontal * PlayerSpeed, rb.velocity.y,
            joyStick1.Vertical * PlayerSpeed);

        //Sets up animations
        if (rb.velocity.magnitude > 0)
        {
            m_animator.SetBool("run", true);
            
            if (pUController.moveHintInteger == 1)
            {
                pUController.CloseMoveHint();
            }
            
        }

        //Sets up physics
        Vector3 playerDirection = Vector3.right * joyStick1.Horizontal + Vector3.forward * joyStick1.Vertical;

        //Sets up animations
        if (playerDirection.sqrMagnitude > 0.0f)
        {
            rotatable.transform.rotation = Quaternion.LookRotation(playerDirection, Vector3.up);
            //m_animator.SetBool("run", true);
        } 
        else 
        {
            m_animator.SetBool("run", false);
        }
    }

}


