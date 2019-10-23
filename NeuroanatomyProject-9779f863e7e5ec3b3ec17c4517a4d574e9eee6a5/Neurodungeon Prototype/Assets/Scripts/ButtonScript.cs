using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Canvas question1Canvas;

    private void Start()
    {
        question1Canvas.enabled = false;
        
    }

    public void OpenQuestion()
    {
        //Handles the quest book opening and closing
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
