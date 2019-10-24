using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchScript : MonoBehaviour
{

    public GameObject LightSourceOne;
    public GameObject LightSourceTwo;

    AudioSource myAudio;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Player")
        {

            LightSourceOne.SetActive(true);
            LightSourceTwo.SetActive(true);
            GetComponent<Collider>().enabled = false;

        }

    }

}
