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

    public GameObject comboScore;

    public bool UncoverPlayer;
    public GameObject playerpos;

    AudioSource myAudio;

    public List <GameObject>  fogs = new List <GameObject> ();

    void Start()
    {
        
        LightSourceOne.SetActive(false);
        LightSourceTwo.SetActive(false);

        comboScore = GameObject.Find("GameManagement");

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
            comboScore.GetComponent<ComboScoreEarner>().torchCombo();
            InGameUI.playerpositions = GameObject.FindGameObjectsWithTag("Position");
            if (UncoverMap == true)
            {
                MapPart.SetActive(true);
            }
            if (UncoverPlayer == true)
            {
                for (int i = 0; i < InGameUI.playerpositions.Length; i++)
                {
                    InGameUI.playerpositions[i].SetActive (false);
                }
                playerpos.SetActive(true);
            }
            foreach (GameObject fog in fogs)
            {
                if (fog != null) { 
                fog.GetComponent<Animator>().SetBool("cleared", true);
                fog.GetComponent<FogOfWar>().StartCoroutine("Destroy");
                }
            }
        }

    }

}
