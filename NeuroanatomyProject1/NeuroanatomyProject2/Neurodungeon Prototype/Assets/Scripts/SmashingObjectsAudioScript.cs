using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashingObjectsAudioScript : MonoBehaviour
{

    AudioSource myAudio;

    // Start is called before the first frame update
    void Start()
    {

        myAudio = GetComponent<AudioSource>();

        myAudio.volume = Random.Range(0.16f, 0.20f);
        myAudio.pitch = Random.Range(0.85f, 0.95f);
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
