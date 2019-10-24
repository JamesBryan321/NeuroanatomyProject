using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepAudioScript : MonoBehaviour
{

    public AudioClip footstep;
    public AudioClip footsteptwo;

    public AudioSource myAudio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FootStep()
    {

        myAudio.PlayOneShot(footstep);

    }

    public void FootStepTwo()
    {

        myAudio.PlayOneShot(footsteptwo);

    }

}
