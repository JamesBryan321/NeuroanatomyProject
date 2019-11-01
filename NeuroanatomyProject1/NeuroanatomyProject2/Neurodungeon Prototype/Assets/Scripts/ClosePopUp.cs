using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosePopUp : MonoBehaviour
{
    //public GameObject thisPopUp;
    
    public void CloseWindow()
    {
        this.gameObject.SetActive(false);
    }
}
