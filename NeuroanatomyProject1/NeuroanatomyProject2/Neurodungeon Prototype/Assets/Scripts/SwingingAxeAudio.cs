using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingingAxeAudio : MonoBehaviour
{

    private AudioSource myAudio;

    

    // Start is called before the first frame update
    void Start()
    {

        myAudio = GetComponent<AudioSource>();
        myAudio.volume = 0.74f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AxeSwingAudio()
    {

        myAudio.Play();

    }

}
