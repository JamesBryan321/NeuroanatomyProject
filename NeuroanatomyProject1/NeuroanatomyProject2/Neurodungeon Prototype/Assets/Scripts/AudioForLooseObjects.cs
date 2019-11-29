using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioForLooseObjects : MonoBehaviour
{

    AudioSource myAudio;

    bool touchedGround;
    bool touchedPlayer;

    // Start is called before the first frame update
    void Start()
    {

        touchedPlayer = false;
        touchedGround = false;
        myAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "Ground" && touchedGround == false)
        {

            myAudio.volume = Random.Range(0.09f, 0.13f);
            myAudio.pitch = Random.Range(0.94f, 1f);
            myAudio.Play();
            touchedGround = true;

        }

        if (collision.gameObject.tag == "Player" && touchedPlayer == false)
        {

            myAudio.volume = Random.Range(0.17f, 0.22f);
            myAudio.pitch = Random.Range(0.94f, 1f);
            myAudio.Play();
            touchedPlayer = true;

            Invoke("touchedPlayerTrue", 0.5f);

        }

    }

    void touchedPlayerTrue()
    {

        touchedPlayer = false;

    }

}
