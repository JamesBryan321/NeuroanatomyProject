using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchScript : MonoBehaviour
{

    public GameObject LightSourceOne;
    public GameObject LightSourceTwo;

    AudioSource myAudio;

    public List <GameObject>  fogs = new List <GameObject> ();

    void Start()
    {
        
        LightSourceOne.SetActive(false);
        LightSourceTwo.SetActive(false);

    }


    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Player")
        {

            LightSourceOne.SetActive(true);
            LightSourceTwo.SetActive(true);
            GetComponent<Collider>().enabled = false;

            foreach (GameObject fog in fogs)
            {
                Destroy(fog);
                Score.score += 5;
            }

        }

    }

}
