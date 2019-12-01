using System.Collections.Generic;
using UnityEngine;

public class TorchScript : MonoBehaviour
{

    public GameObject LightSourceOne;
    public GameObject LightSourceTwo;
    public bool UncoverMap;
    public GameObject MapPart;
    public GameObject Canvas;
    public GameObject scorePrefab;

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

            Score.score += 25;
            GameObject Text = Instantiate(scorePrefab, new Vector3(0f, 890f, 0f), Quaternion.identity);
            Text.transform.SetParent(Canvas.transform, false);

            foreach (GameObject fog in fogs)
            {
                fog.GetComponent<Animator>().SetBool("cleared", true);               
                
            }
            if (UncoverMap == true)
            {
                MapPart.SetActive(true);
            }

        }

    }

}
