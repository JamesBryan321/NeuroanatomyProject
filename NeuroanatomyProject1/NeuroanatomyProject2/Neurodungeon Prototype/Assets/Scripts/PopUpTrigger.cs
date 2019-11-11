using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpTrigger : MonoBehaviour
{
    public PopUpController pUController;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            pUController.OpenInteractableHint();
            Destroy(this.gameObject);
        }
    }
}
