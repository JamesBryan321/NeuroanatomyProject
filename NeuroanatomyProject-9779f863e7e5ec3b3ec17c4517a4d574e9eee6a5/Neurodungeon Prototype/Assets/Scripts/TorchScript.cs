using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchScript : MonoBehaviour
{

    public AudioClip TorchFadeIn;
    public AudioClip TorchLoop;

    public GameObject LightSourceOne;
    public GameObject LightSourceTwo;

    AudioSource myAudio;

    // Start is called before the first frame update
    void Start()
    {

        myAudio = GetComponent<AudioSource>();
        myAudio.clip = TorchFadeIn;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Player")
        {

            myAudio.Play();
            Invoke("TorchLooping", 15.3f);
            LightSourceOne.SetActive(true);
            LightSourceTwo.SetActive(true);
            GetComponent<Collider>().enabled = false;

        }

    }

    void TorchLooping()
    {

        myAudio.clip = TorchLoop;
        myAudio.Play();

    }

}
