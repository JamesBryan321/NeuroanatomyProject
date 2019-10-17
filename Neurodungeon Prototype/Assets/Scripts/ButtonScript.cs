using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Canvas question1Canvas;

    private void Start()
    {
        question1Canvas.enabled = false;
        
    }

    public void OpenQuestion()
    {
        if (question1Canvas.enabled == false)
        {
            question1Canvas.enabled = true;
            
        }
        else if (question1Canvas.enabled == true)
        {
            question1Canvas.enabled = false;
            
        }
    }
}
