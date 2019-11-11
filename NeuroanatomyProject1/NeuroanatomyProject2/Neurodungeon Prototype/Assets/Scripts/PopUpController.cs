using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpController : MonoBehaviour
{
    public GameObject[] popUps;
    public int moveHintInteger;
    public int interactableHintInteger;
    public int journalHintInteger;
    
    
    void Start()
    {
        for (int i = 1; i < popUps.Length; i++)
        {
            popUps[i].SetActive(false);
        }
    }

    public void OpenMoveHint()
    {       
        popUps[1].SetActive(true);
        moveHintInteger = 1;
    }

    public void CloseMoveHint()
    {
        popUps[1].SetActive(false);
        moveHintInteger = 0;
    }

    public void OpenInteractableHint()
    {
        popUps[2].SetActive(true);
        interactableHintInteger = 1;
    }
    
    public void CloseInteractableHint()
    {
        popUps[2].SetActive(false);
        interactableHintInteger = 0;
    }
    
    public void OpenJournalHint()
    {
        popUps[3].SetActive(true);
        journalHintInteger = 1;
    }
    
    public void CloseJournalHint()
    {
        popUps[3].SetActive(false);
        journalHintInteger = 0;
    }
}
