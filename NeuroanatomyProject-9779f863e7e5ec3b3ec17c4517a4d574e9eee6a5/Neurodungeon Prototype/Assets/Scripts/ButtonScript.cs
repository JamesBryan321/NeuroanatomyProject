using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Canvas question1Canvas;

    public AudioClip journalOpening;
    public AudioClip journalClosing;

    AudioSource myAudio;

    private void Start()
    {
        question1Canvas.enabled = false;
        myAudio = GetComponent<AudioSource>();
        
    }

    public void OpenQuestion()
    {
        //Handles the quest book opening and closing
        if (question1Canvas.enabled == false)
        {
            question1Canvas.enabled = true;
            myAudio.clip = journalOpening;
            myAudio.Play();
        }
        else if (question1Canvas.enabled == true)
        {
            question1Canvas.enabled = false;
            myAudio.clip = journalClosing;
            myAudio.Play();
        }
    }
}
