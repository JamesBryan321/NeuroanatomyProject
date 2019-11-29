using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainScript : MonoBehaviour
{

    private AudioSource myAudio;
    private Animator myAnimator;
    public AudioClip brainIdle;
    public AudioClip brainSplat;

    public float time = 2f;
    public float timer;
    public bool timeTrue;

    // Start is called before the first frame update
    void Start()
    {

        myAudio = GetComponent<AudioSource>();
        myAnimator = GetComponent<Animator>();
        timer = time;

    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;
        if (timer <= 0)
        {

            timeTrue = true;

        }
        else
        {

            timeTrue = false;

        }

    }

    public void BrainHit()
    {

        if (timeTrue == true)
        {

            myAudio.clip = brainSplat;
            myAudio.volume = Random.Range(0.67f, 0.73f);
            myAudio.pitch = Random.Range(0.9f, 1f);
            myAudio.Play();
            myAnimator.Play("BrainHit");
            timer = time;

        }

    }

}
