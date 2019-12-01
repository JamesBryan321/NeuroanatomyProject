using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpTrigger : MonoBehaviour
{
    public PopUpController pUController;
    public string type;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            if (type == "Interactable") { 
               pUController.OpenInteractableHint();
               Destroy(this.gameObject);
            }
            if (type == "Journal") { 
                pUController.OpenJournalHint();
                Destroy(this.gameObject);
            }
            if (type == "Obstacle")
            {
                pUController.OpenObstacleHint();
                Destroy(this.gameObject);
            }
            if (type == "Prisoner")
            {
                pUController.OpenPrisonerHint();
                Destroy(this.gameObject);
            }
            if (type == "Destructable")
            {
                pUController.OpenDestructableHint();
                Destroy(this.gameObject);
            }
        }

        
    }
}
