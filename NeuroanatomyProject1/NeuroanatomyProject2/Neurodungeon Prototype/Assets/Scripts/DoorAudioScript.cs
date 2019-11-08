using UnityEngine;

public class DoorAudioScript : MonoBehaviour
{

    public AudioClip Unlocking;
    public AudioClip Opening;

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

}
