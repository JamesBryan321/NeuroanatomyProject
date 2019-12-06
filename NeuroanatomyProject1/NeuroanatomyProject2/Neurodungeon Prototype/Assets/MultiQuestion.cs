using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiQuestion : MonoBehaviour
{
    public bool one = false;
    public bool two = false;
    public GameObject correct1;
    public GameObject correct2;
    public InGameUI ui;
    public CloseInteractable close;
    public questionManager manager;
    public void CorrectAnswer(int number)
    {
        if (number == 1)
        {
            one = true;
            correct1.SetActive(false);
        }
        if (number == 2)
        {
            two = true;
            correct2.SetActive(false);
        }
        if (one == true && two == true)
        {
            Right();
        }

    }
    void Right ()
    {
        ui.OnRightAnswer();
        close.Toggle(true);
        manager.EnableCorrectCanvas();
        correct1.SetActive(true);
        correct2.SetActive(true);
    }

    public void Wrong ()
    {
        ui.OnWrongAnswer();
        close.Toggle(true);
        manager.EnableWrongCanvas1();
        correct1.SetActive(true);
        correct2.SetActive(true);
        one = false;
        two = false;
    }

}
