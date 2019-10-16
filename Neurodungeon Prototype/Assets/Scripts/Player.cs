using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public FixedJoystick joyStick1;
    
    public float PlayerSpeed;
    
    void Start()
    {
        //anim = GetComponentInChildren<Animator>();

        //Move.enabled = true;
        //arrow1.enabled = true;
        //aim.enabled = false;
        //arrow2.enabled = false;
        //PickUp = false;

    }

    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joyStick1.Horizontal * PlayerSpeed, rigidbody.velocity.y,
            joyStick1.Vertical * PlayerSpeed);


        Vector3 playerDirection = Vector3.right * joyStick1.Horizontal + Vector3.forward * joyStick1.Vertical;
        if (playerDirection.sqrMagnitude > 0.0f)
        {
            transform.rotation = Quaternion.LookRotation(playerDirection, Vector3.up);
        }
    }

}


