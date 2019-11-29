using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepAudioScript : MonoBehaviour
{

    //AudioClips
    public AudioClip footstepOne;
    public AudioClip footstepTwo;
    public AudioClip rugFootstepOne;
    public AudioClip rugFootstepTwo;
    public AudioClip waterFootstepOne;
    public AudioClip waterFootstepTwo;

    //Bools
    bool RugAudio;
    bool WaterAudio;

    //AudioSource
    public AudioSource myAudio;

    // Start is called before the first frame update
    void Start()
    {

        WaterAudio = false;

    }

    //Handles exiting trigger colliders
    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Rug")
        {

            RugAudio = false;

        }

        if (other.tag == "Water")
        {

            WaterAudio = false;

        }

    }

    //Handles entering trigger colliders
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Rug")
        {

            Invoke("touchingRug", 0.15f);

        }

        if (other.tag == "Water")
        {

            touchingWater();

        }

    }

        //function to enable rug footsteps
        void touchingRug()
    {

        RugAudio = true;

    }

    //function to enable water footsteps
    void touchingWater()
    {

        WaterAudio = true;

    }

    //controls which footstep clips are playing depending on above bools. Randomizes volume and pitch for repeatability.
    public void FootStep()
    {

        if (RugAudio == true)
        {

            myAudio.PlayOneShot(rugFootstepOne);
            myAudio.volume = Random.Range(0.17f, 0.22f);
            myAudio.pitch = Random.Range(0.6f, 1.3f);

        }
        else if(WaterAudio == true)
        {

            myAudio.PlayOneShot(waterFootstepOne);
            myAudio.volume = Random.Range(0.28f, 0.34f);
            myAudio.pitch = Random.Range(0.6f, 1.3f);

        }
        else
        {

            myAudio.PlayOneShot(footstepOne);
            myAudio.volume = Random.Range(0.18f, 0.24f);
            myAudio.pitch = Random.Range(0.6f, 1.3f);

        }

    }

    //controls which footstep clips are playing depending on above bools. Randomizes volume and pitch for repeatability.
    public void FootStepTwo()
    {

        if (RugAudio == true)
        {

            myAudio.PlayOneShot(rugFootstepTwo);
            myAudio.volume = Random.Range(0.17f, 0.22f);
            myAudio.pitch = Random.Range(0.6f, 1.3f);

        }
        else if (WaterAudio == true)
        {

            myAudio.PlayOneShot(waterFootstepTwo);
            myAudio.volume = Random.Range(0.28f, 0.34f);
            myAudio.pitch = Random.Range(0.6f, 1.3f);

        }
        else
        {

            myAudio.PlayOneShot(footstepTwo);
            myAudio.volume = Random.Range(0.18f, 0.24f);
            myAudio.pitch = Random.Range(0.6f, 1.3f);

        }

    }

}
