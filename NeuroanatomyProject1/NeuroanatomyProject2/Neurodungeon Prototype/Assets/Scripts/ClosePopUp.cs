using UnityEngine;

public class ClosePopUp : MonoBehaviour
{

    public PopUpController pUController;
    public GameObject moveHint;
   

    public void CloseWindow()
    {
        this.gameObject.SetActive(false);        
    }
}
