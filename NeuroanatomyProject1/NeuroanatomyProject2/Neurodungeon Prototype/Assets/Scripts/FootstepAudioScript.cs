using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepAudioScript : MonoBehaviour
{

    public AudioClip footstep;
    public AudioClip footsteptwo;
    public AudioClip rugFootstepOne;
    public AudioClip rugFootstepTwo;

    bool RugAudio;

    public AudioSource myAudio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Rug")
        {

            Invoke("touchingRug", 0.1f);

        }


    }

    void touchingRug()
    {

        RugAudio = true;

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Rug")
        {

            RugAudio = false;

        }

    }

    public void FootStep()
    {

        if (RugAudio == true)
        {

            myAudio.PlayOneShot(rugFootstepOne);
            myAudio.volume = Random.Range(0.05f, 0.11f);
            myAudio.pitch = Random.Range(0.6f, 1.3f);

        }
        else
        {

            myAudio.PlayOneShot(footstep);
            myAudio.volume = Random.Range(0.05f, 0.11f);
            myAudio.pitch = Random.Range(0.6f, 1.3f);

        }

    }

    public void FootStepTwo()
    {

        if (RugAudio == true)
        {

            myAudio.PlayOneShot(rugFootstepTwo);
            myAudio.volume = Random.Range(0.05f, 0.11f);
            myAudio.pitch = Random.Range(0.6f, 1.3f);

        }
        else
        {

            myAudio.PlayOneShot(footsteptwo);
            myAudio.volume = Random.Range(0.05f, 0.11f);
            myAudio.pitch = Random.Range(0.6f, 1.3f);

        }

    }

}
