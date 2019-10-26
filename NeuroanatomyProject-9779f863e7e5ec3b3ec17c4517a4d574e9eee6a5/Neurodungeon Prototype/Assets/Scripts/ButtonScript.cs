﻿using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Canvas menuCanvas;
    public Canvas question1Canvas;
    public Canvas question2Canvas;

    public InGameUI uIScript;

    public AudioClip journalOpening;
    public AudioClip journalClosing;

    public GameObject prisoner1;
    public Animator p1Animator;

    public GameObject prisonCell1;
    public Animator prisonCell1Animator;

    AudioSource myAudio;

    private void Start()
    {
        question1Canvas.enabled = false;
        question2Canvas.enabled = false;

        p1Animator = prisoner1.GetComponent<Animator>();
        prisonCell1Animator = prisonCell1.GetComponent<Animator>();
        
        myAudio = GetComponent<AudioSource>();
        
    }
    
    public void OpenMenu()
    {
       
            if (menuCanvas.enabled == false)
            {
                menuCanvas.enabled = true;
                uIScript.OnMapButton();
                myAudio.clip = journalOpening;
                myAudio.Play();
            }
            else if (menuCanvas.enabled == true)
            {
                menuCanvas.enabled = false;
                myAudio.clip = journalClosing;
                myAudio.Play();
            }
    }

    public void OpenQuestion1(int questionIndex)
    {
        if (questionIndex == 1)
        {
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
        
        if (questionIndex == 2)
        {
            if (question2Canvas.enabled == false)
            {
                question2Canvas.enabled = true;
                myAudio.clip = journalOpening;
                myAudio.Play();
            }
            else if (question2Canvas.enabled == true)
            {
                question2Canvas.enabled = false;
                myAudio.clip = journalClosing;
                p1Animator.SetBool("Correct", true);
                prisonCell1Animator.SetBool("Correct", true);
                myAudio.Play();
            }
        }
    }
}
