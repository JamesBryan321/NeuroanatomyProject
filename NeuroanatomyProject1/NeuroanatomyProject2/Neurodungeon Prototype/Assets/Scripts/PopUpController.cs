using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpController : MonoBehaviour
{
    public GameObject[] popUps;
    public int moveHintInteger = 1;
    public int interactableHintInteger;
    public int journalHintInteger;
    public int journalCloseHintInteger;
    public int obstaclesHintInteger;
    public int prisonerHintInteger;
    public Player playerScript;
    //public GameObject player;


    void Start()
    {
        //playerScript = player.GetComponent<Player>();
        
        for (int i = 1; i < popUps.Length; i++)
        {
            popUps[i].SetActive(false);
        }
        OpenMoveHint();
    }

    public void OpenMoveHint()
    {
        popUps[1].SetActive(true);
        moveHintInteger = 1;
        //playerScript.LockJoystick();
    }

    public void CloseMoveHint()
    {

        popUps[1].SetActive(false);
        moveHintInteger = 0;
        //playerScript.UnlockJoystick();
    }

    public void OpenInteractableHint()
    {
        popUps[2].SetActive(true);
        interactableHintInteger = 1;
        playerScript.LockJoystick();
    }
    
    public void CloseInteractableHint()
    {
        popUps[2].SetActive(false);
        interactableHintInteger = 0;
        playerScript.UnlockJoystick();
    }
    
    public void OpenJournalHint()
    {
        popUps[3].SetActive(true);
        popUps[2].SetActive(false);
        popUps[1].SetActive(false);
        popUps[0].SetActive(false);
        moveHintInteger = 0;
        interactableHintInteger = 0;
        journalHintInteger = 1;
        playerScript.LockJoystick();
    }
    
    public void CloseJournalHint()
    {
        popUps[3].SetActive(false);
        journalHintInteger = 0;
        playerScript.UnlockJoystick();
        CloseJournalCloseHint();
        if (journalCloseHintInteger == 1)
        {
            CloseJournalCloseHint();
            return;
        }
        OpenJournalCloseHint();
    }

    public void OpenObstacleHint ()
    {
        popUps[4].SetActive(true);
        obstaclesHintInteger = 1;
        playerScript.LockJoystick();
    }
    public void CloseObstacleHint()
    {
        popUps[4].SetActive(true);
        obstaclesHintInteger = 0;
        playerScript.UnlockJoystick();
    }
    public void OpenPrisonerHint()
    {
        popUps[5].SetActive(true);
        prisonerHintInteger = 1;
        playerScript.LockJoystick();
    }
    public void ClosePrisonerHint()
    {
        popUps[5].SetActive(true);
        prisonerHintInteger = 0;
        playerScript.UnlockJoystick();
    }
    
    public void OpenJournalCloseHint()
    {
        popUps[6].SetActive(true);
        journalCloseHintInteger++;
        playerScript.LockJoystick();
    }
    public void CloseJournalCloseHint()
    {
        popUps[6].SetActive(false);
        //journalCloseHintInteger = 0;
        playerScript.UnlockJoystick();
        //Destroy(popUps[6]);
    }
}
