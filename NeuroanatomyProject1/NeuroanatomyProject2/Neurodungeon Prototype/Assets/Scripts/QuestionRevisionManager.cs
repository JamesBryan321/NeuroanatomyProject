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
    public GameObject question5;
    public GameObject question6;
    public GameObject question7;
    public GameObject question8;
    public GameObject question9;
    public GameObject question10;
    public GameObject question11;
    public GameObject question12;
    public GameObject question13;
    public GameObject question14;
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
    public void Question5()
    {
        ingameUI.SetActive(false);
        question5.GetComponent<Canvas>().enabled = true;
    }
    public void Question6()
    {
        ingameUI.SetActive(false);
        question6.GetComponent<Canvas>().enabled = true;
    }
    public void Question7()
    {
        ingameUI.SetActive(false);
        question7.GetComponent<Canvas>().enabled = true;
    }
    public void Question8()
    {
        ingameUI.SetActive(false);
        question8.GetComponent<Canvas>().enabled = true;

    }
    public void Question9()
    {
        ingameUI.SetActive(false);
        question9.GetComponent<Canvas>().enabled = true;
    }
    public void Question10()
    {
        ingameUI.SetActive(false);
        question10.GetComponent<Canvas>().enabled = true;
    }
    public void Question11()
    {
        ingameUI.SetActive(false);
        question11.GetComponent<Canvas>().enabled = true;
    }
    public void Question12()
    {
        ingameUI.SetActive(false);
        question12.GetComponent<Canvas>().enabled = true;

    }
    public void Question13()
    {
        ingameUI.SetActive(false);
        question13.GetComponent<Canvas>().enabled = true;
    }
    public void Question14()
    {
        ingameUI.SetActive(false);
        question14.GetComponent<Canvas>().enabled = true;
    }
}
