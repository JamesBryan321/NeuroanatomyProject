using UnityEngine;

public class PrisonerAudio : MonoBehaviour
{

    AudioSource myAudio;

    public AudioClip Crying;
    public AudioClip Music;

    bool prisonerSaved = false;

    // Start is called before the first frame update
    void Start()
    {

        myAudio = GetComponent<AudioSource>();

        myAudio.volume = 0.24f;
        myAudio.clip = Crying;
        myAudio.Play();

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void saved()
    {

        if (prisonerSaved == false)
        {

            prisonerSaved = true;
            myAudio.volume = 0.36f;
            myAudio.clip = Music;
            myAudio.Play();

        }

    }

}
