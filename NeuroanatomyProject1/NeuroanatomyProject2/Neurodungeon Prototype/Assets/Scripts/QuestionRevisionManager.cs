using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionRevisionManager : MonoBehaviour
{
    public GameObject[] questionsarray;
    public GameObject question1;
    public GameObject question2;
    public GameObject question3;
    public GameObject question4;
    public GameObject ingameUI;
    private void Start()
    {
        
    }
    public void Question (int question, bool correct)
    {
        string questionname = "Question " + question;
        for (int i = 0; i < questionsarray.Length; i++)
        {
            if (questionname == questionsarray [i].name)
            {
                questionsarray[i].SetActive(true);
                if (correct == false)
                {
                    questionsarray[i].GetComponent<Image>().color = Color.red;
                }
                else if (correct == true)
                {
                    questionsarray[i].GetComponent<Image>().color = Color.green;
                }
            }
        }

    }

    public void Question1 ()
    {
        ingameUI.SetActive(false);
        question1.GetComponent<Canvas>().enabled = true;
    }
    public void Question2()
    {
        ingameUI.SetActive(false);
        question2.GetComponent<Canvas>().enabled = true;
    }
    public void Question3()
    {
        ingameUI.SetActive(false);
        question3.GetComponent<Canvas>().enabled = true;
    }
    public void Question4()
    {
        ingameUI.SetActive(false);
        question4.GetComponent<Canvas>().enabled = true;
    }
}
