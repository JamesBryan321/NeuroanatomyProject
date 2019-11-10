using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScriptForRollingObjects : MonoBehaviour
{

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

    void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Ground")
        {

            myAudio.volume = Random.Range(0.01f, 0.03f);
            myAudio.Play();

        }

    }

}
