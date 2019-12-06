using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionManager : MonoBehaviour
{
    public Canvas wrongAnswer1Canvas;
    public Canvas wrongAnswer2Canvas;
    public Canvas wrongAnswer3Canvas;
    public Canvas correctAnswerCanvas;

    public Player playerScript;
    
    void Start()
    {

        wrongAnswer1Canvas.enabled = false;
        wrongAnswer2Canvas.enabled = false;
        wrongAnswer3Canvas.enabled = false;
        correctAnswerCanvas.enabled = false;
    }

    public void EnableWrongCanvas1()
    {
      //  Debug.Log("Here's why you're wrong...");
        /*this is currently disabled as darren hasn't provided the explanations
        instead a correct/wrong answer will just close the question, then when
        we have the explanations we need only re-enable this line of code and 
        remove the below.
        wrongAnswer1Canvas.enabled = true;*/
        playerScript.UnlockJoystick();
    }
    
    public void EnableWrongCanvas2()
    {
      // Debug.Log("Here's why you're wrong...");
       /*this is currently disabled as darren hasn't provided the explanations
        instead a correct/wrong answer will just close the question, then when
        we have the explanations we need only re-enable this line of code and 
        remove the below.
        wrongAnswer2Canvas.enabled = true;*/
       playerScript.UnlockJoystick();
    }
    
    public void EnableWrongCanvas3()
    {
      //  Debug.Log("Here's why you're wrong...");
        /*this is currently disabled as darren hasn't provided the explanations
        instead a correct/wrong answer will just close the question, then when
        we have the explanations we need only re-enable this line of code and 
        remove the below.
        wrongAnswer3Canvas.enabled = true;*/
        playerScript.UnlockJoystick();
    }
    
    public void EnableCorrectCanvas()
    {
      //  Debug.Log("Here's why you're right!");
       /*this is currently disabled as darren hasn't provided the explanations
        instead a correct/wrong answer will just close the question, then when
        we have the explanations we need only re-enable this line of code and 
        remove the below.
        correctAnswerCanvas.enabled = true;*/
       playerScript.UnlockJoystick();
    }
    
    /*maybe change the code within these just to re-enable the Joystick
        that way the lack of "reason you're right/wrong" won't be evident x*/
}
