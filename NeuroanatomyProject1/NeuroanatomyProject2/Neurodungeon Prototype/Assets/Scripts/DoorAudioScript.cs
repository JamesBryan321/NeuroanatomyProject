using UnityEngine;

public class DoorAudioScript : MonoBehaviour
{

    public AudioClip Unlocking;
    public AudioClip Opening;
    public AudioClip debrisSmashing;

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

}
