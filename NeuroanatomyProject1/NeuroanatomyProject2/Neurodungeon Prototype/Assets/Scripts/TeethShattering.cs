using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeethShattering : MonoBehaviour
{
    AudioSource mAudio;

    public AudioClip shatter;

    // Start is called before the first frame update
    void Start()
    {
        mAudio = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void teethShatter()
    {

        mAudio.loop = false;
        mAudio.clip = shatter;
        mAudio.Play();

    }

}
