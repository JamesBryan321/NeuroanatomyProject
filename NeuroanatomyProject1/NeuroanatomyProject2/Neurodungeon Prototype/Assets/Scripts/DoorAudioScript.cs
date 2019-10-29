using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAudioScript : MonoBehaviour
{

    public AudioClip Unlocking;
    public AudioClip Opening;

    AudioSource myAudio;

    // Start is called before the first frame update
    void Start()
    {

        myAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void doorUnlock()
    {

        myAudio.clip = Unlocking;
        myAudio.Play();

    }

    void doorOpening()
    {

        myAudio.clip = Opening;
        myAudio.Play();

    }

}
