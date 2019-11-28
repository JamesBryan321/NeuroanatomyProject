using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionManager : MonoBehaviour
{
    public Canvas wrongAnswer1Canvas;
    public Canvas wrongAnswer2Canvas;
    public Canvas wrongAnswer3Canvas;
    public Canvas correctAnswerCanvas;
    
    void Start()
    {

        wrongAnswer1Canvas.enabled = false;
        wrongAnswer2Canvas.enabled = false;
        wrongAnswer3Canvas.enabled = false;
        correctAnswerCanvas.enabled = false;
    }

    public void EnableWrongCanvas1()
    {
        //Debug.Log("Here's why you're wrong...");
        wrongAnswer1Canvas.enabled = true;
    }
    
    public void EnableWrongCanvas2()
    {
       // Debug.Log("Here's why you're wrong...");
        wrongAnswer2Canvas.enabled = true;
    }
    
    public void EnableWrongCanvas3()
    {
        //Debug.Log("Here's why you're wrong...");
        wrongAnswer3Canvas.enabled = true;
    }
    
    public void EnableCorrectCanvas()
    {
       // Debug.Log("Here's why you're right!");
        correctAnswerCanvas.enabled = true;
    }
}
