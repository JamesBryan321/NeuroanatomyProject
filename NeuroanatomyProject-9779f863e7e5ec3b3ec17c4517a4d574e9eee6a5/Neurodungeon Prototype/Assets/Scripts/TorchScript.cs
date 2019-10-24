using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchScript : MonoBehaviour
{

    public GameObject LightSourceOne;
    public GameObject LightSourceTwo;

    AudioSource myAudio;

    public GameObject[] fogplanes;


    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Player")
        {

            LightSourceOne.SetActive(true);
            LightSourceTwo.SetActive(true);
            GetComponent<Collider>().enabled = false;

            for (int i = 0; i < fogplanes.Length; i++)
            {
                Destroy(fogplanes[i]);
                Score.score += 5;
            }

        }

    }

}
