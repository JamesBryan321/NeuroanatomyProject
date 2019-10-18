using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public FixedJoystick joyStick1;
    
    public float PlayerSpeed;
    public Animator m_animator;

    public Rigidbody rb;

    public GameObject rotatable;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_animator = GetComponent<Animator>();
        m_animator.SetBool("run", false);
    }

    void Update()
    {
        rb.velocity = new Vector3(joyStick1.Horizontal * PlayerSpeed, rb.velocity.y,
            joyStick1.Vertical * PlayerSpeed);

        if (rb.velocity.magnitude > 0)
        {
            m_animator.SetBool("run", true);
        }

        Vector3 playerDirection = Vector3.right * joyStick1.Horizontal + Vector3.forward * joyStick1.Vertical;
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


