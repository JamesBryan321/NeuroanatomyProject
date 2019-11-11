using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalPopUpTrigger : MonoBehaviour
{
    public PopUpController pUController;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            pUController.OpenJournalHint();
            Destroy(this.gameObject);
        }
    }
}
