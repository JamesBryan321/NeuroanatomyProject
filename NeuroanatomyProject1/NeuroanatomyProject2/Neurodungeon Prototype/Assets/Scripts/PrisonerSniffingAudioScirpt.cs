using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrisonerSniffingAudioScirpt : MonoBehaviour
{

    AudioSource myAudio;

    public AudioClip[] sniff;
    private AudioClip sniffClip;

    public int noseIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        noseIndex = 0;

        InvokeRepeating("sniffAudio", 1f, 7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void sniffAudio()
    {

        int noseIndex = Random.Range(0, sniff.Length);
        myAudio.volume = Random.Range(0.175f, 0.20f);
        myAudio.pitch = Random.Range(0.95f, 1f);
        sniffClip = sniff[noseIndex];
        myAudio.clip = sniffClip;
        myAudio.Play();

    }

}
