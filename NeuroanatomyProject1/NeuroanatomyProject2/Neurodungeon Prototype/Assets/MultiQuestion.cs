using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiQuestion : MonoBehaviour
{
    public int previous = 0;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject option4;
    public InGameUI ui;
    public CloseInteractable close;
    public questionManager manager;
    public QuestionRevisionManager revision;
    public void AnswerResponse(int number)
    {


        if (previous == 3)
        {
            if (number == 4)
            {
                Right();
            }
            else
            {
                Wrong();
            }
        }

        if (previous == 2)
            {
                if (number == 3)
                {
                    option3.SetActive(false);
                    previous = 3;
                }
                else
                {
                    Wrong();
            }
            }

            if (previous == 1)
            {
                if (number == 2)
                {
                    option2.SetActive(false);
                    previous = 2;
                }
                else
                {
                    Wrong();
            }
            }

            if (previous == 0)
            {
                if (number == 1)
                {
                    option1.SetActive(false);
                    previous = 1;
                }
                else
                {
                    Wrong();
            }
        }
    }
    void Right ()
    {
        revision.Question(6, true);
        ui.OnRightAnswer();
        close.Toggle(true);
        manager.EnableCorrectCanvas();
        option1.SetActive(true);
        option2.SetActive(true);
        option3.SetActive(true);
        option4.SetActive(true);
    }

    void Wrong ()
    {
        revision.Question(6, false);
        ui.OnWrongAnswer();
        close.Toggle(true);
        manager.EnableWrongCanvas1();
        option1.SetActive(true);
        option2.SetActive(true);
        option3.SetActive(true);
        option4.SetActive(true);
        previous = 0;
    }


}
