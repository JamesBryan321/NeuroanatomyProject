using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionRevisionManager : MonoBehaviour
{
    public GameObject[] questionsarray;

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
}
