using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTest : MonoBehaviour
{
    public Animator anim;
    public GameObject finaltestgameobject;
    public Player player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            anim.SetBool("close", true);
            finaltestgameobject.tag = "Interactable";
            finaltestgameobject.layer = 8;
        }
    }

    public void PassedFinalTest ()
    {
        anim.SetBool("close", false);
        finaltestgameobject.tag = "notInteractable";
        player.UnlockJoystick();
        
    }
}
