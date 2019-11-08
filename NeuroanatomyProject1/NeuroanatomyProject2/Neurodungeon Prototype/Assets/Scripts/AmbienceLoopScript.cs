using UnityEngine;

public class AmbienceLoopScript : MonoBehaviour
{

    AudioSource myAudio;


    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        myAudio.PlayDelayed(157.0f);

    }
}
