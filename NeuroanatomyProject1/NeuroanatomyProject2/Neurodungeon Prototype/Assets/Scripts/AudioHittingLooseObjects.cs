using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHittingLooseObjects : MonoBehaviour
{

    AudioSource myAudio;

    public AudioClip hardAudio;
    public AudioClip squishyAudio;

    // Start is called before the first frame update
    void Start()
    {

        myAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "Solid")
        {

            myAudio.clip = hardAudio;
            myAudio.volume = Random.Range(0.03f, 0.08f);
            myAudio.pitch = Random.Range(0.9f, 1f);
            myAudio.Play();

        }

        if (collision.gameObject.tag == "Squishy")
        {

            myAudio.clip = squishyAudio;
            myAudio.volume = Random.Range(0.18f, 0.25f);
            myAudio.pitch = Random.Range(0.9f, 1f);
            myAudio.Play();

        }

    }

}
