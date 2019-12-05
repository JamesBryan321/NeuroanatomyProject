using UnityEngine;

public class DoorAudioScript : MonoBehaviour
{

    public AudioClip Unlocking;
    public AudioClip Opening;
    public AudioClip debrisSmashing;
    public AudioClip spikes;
    public AudioClip axeSwing;
    public AudioClip portcullisOpen;
    public AudioClip portcullisClose;

    AudioSource myAudio;

    void Start()
    {

        myAudio = GetComponent<AudioSource>();

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

    void doorSmash()
    {

        myAudio.clip = debrisSmashing;
        myAudio.Play();

    }

    void spikesAudio()
    {

        myAudio.clip = spikes;
        myAudio.Play();

    }


    void axeSwingAudio()
    {

        myAudio.clip = axeSwing;
        myAudio.Play();

    }

    void portcullisOpenAudio()
    {

        myAudio.clip = portcullisOpen;
        myAudio.Play();

    }

    void portcullisCloseAudio()
    {

        myAudio.clip = portcullisClose;
        myAudio.Play();

    }

}
