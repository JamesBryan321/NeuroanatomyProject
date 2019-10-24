using UnityEngine;

public class TorchAudioScript : MonoBehaviour
{

    public AudioClip TorchFadeIn;
    public AudioClip TorchLoop;

    AudioSource myAudio;

    void Start()
    {

        myAudio = GetComponent<AudioSource>();
        myAudio.clip = TorchFadeIn;

    }



    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {

            myAudio.Play();
            Invoke("TorchLooping", 15.3f);
         
            GetComponent<Collider>().enabled = false;
        }

    }

    void TorchLooping()
    {

        myAudio.clip = TorchLoop;
        myAudio.Play();

    }

}

