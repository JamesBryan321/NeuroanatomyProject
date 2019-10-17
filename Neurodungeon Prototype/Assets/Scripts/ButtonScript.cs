using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Image question1;

    private void Start()
    {
        question1.enabled = false;
    }

    public void OpenQuestion()
    {
        if (question1.enabled == false)
        {
            question1.enabled = true;
        }
        else if (question1.enabled == true)
        {
            question1.enabled = false;
        }
    }
}
