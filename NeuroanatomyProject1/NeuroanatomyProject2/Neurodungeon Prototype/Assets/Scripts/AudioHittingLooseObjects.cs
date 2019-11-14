using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHittingLooseObjects : MonoBehaviour
{

    AudioSource myAudio;

    public AudioClip hardAudio;
    public AudioClip squishyAudio;
    public AudioClip woodAudio;
    public AudioClip metalAudio;
    public AudioClip wallAudio;
    public AudioClip[] glassAudio;
    private AudioClip glassSoundEffect;

    public int glassInt;

    bool touchedObject;

    // Start is called before the first frame update
    void Start()
    {

        glassInt = 0;
        touchedObject = false;
        myAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "Solid" && touchedObject == false)
        {

            myAudio.clip = hardAudio;
            myAudio.volume = Random.Range(0.03f, 0.08f);
            myAudio.pitch = Random.Range(0.9f, 1f);
            myAudio.Play();

            touchedObject = true;
            Invoke("touchedObjectTrue", 0.5f);

        }

        if (collision.gameObject.tag == "Squishy" && touchedObject == false)
        {

            myAudio.clip = squishyAudio;
            myAudio.volume = Random.Range(0.18f, 0.25f);
            myAudio.pitch = Random.Range(0.9f, 1f);
            myAudio.Play();

            touchedObject = true;
            Invoke("touchedObjectTrue", 0.5f);

        }

        if (collision.gameObject.tag == "Glass" && touchedObject == false)
        {

            int glassIndex = Random.Range(0, glassAudio.Length);
            glassSoundEffect = glassAudio[glassIndex];
            myAudio.clip = glassSoundEffect;
            myAudio.Play();

            touchedObject = true;
            Invoke("touchedObjectTrue", 0.5f);


        }

        if (collision.gameObject.tag == "Metal" && touchedObject == false)
        {

            myAudio.clip = metalAudio;
            myAudio.volume = Random.Range(0.12f, 0.18f);
            myAudio.pitch = Random.Range(0.95f, 1f);
            myAudio.Play();

            touchedObject = true;
            Invoke("touchedObjectTrue", 0.5f);

        }

        if (collision.gameObject.tag == "Wood" && touchedObject == false)
        {

            myAudio.clip = woodAudio;
            myAudio.volume = Random.Range(0.12f, 0.18f);
            myAudio.pitch = Random.Range(0.95f, 1f);
            myAudio.Play();

            touchedObject = true;
            Invoke("touchedObjectTrue", 0.5f);

        }

        if (collision.gameObject.tag == "Wall" && touchedObject == false)
        {

            myAudio.clip = wallAudio;
            myAudio.volume = Random.Range(0.12f, 0.18f);
            myAudio.pitch = Random.Range(0.95f, 1f);
            myAudio.Play();

            touchedObject = true;
            Invoke("touchedObjectTrue", 0.5f);

        }

    }

    void touchedObjectTrue()
    {

        touchedObject = false;

    }

}
