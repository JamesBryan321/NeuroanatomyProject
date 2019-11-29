using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AreaComplete : MonoBehaviour
{

    public AudioSource gameManagementAudio;

    public AudioClip scoreSound;

    public List<GameObject> fogs = new List<GameObject>();
    public GameObject completeText;

    public GameObject Canvas;
    public GameObject scorePrefab;

    bool pointsgiven = false;

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fog")
        {
            fogs.Add(other.gameObject);
        }
    }

    private void Update()
    {
        fogs.RemoveAll(GameObject => GameObject == null);
        if (fogs.Count == 0)
        {
            
            

            playScoreSound();

            StartCoroutine("TextUI");
        }
    }

    void playScoreSound()
    {

        gameManagementAudio.volume = 0.32f;
        gameManagementAudio.clip = scoreSound;
        gameManagementAudio.Play();

    }

    IEnumerator TextUI ()
    {
    if (pointsgiven == false) {
        pointsgiven = true;
        Score.score += 200;
        GameObject Text = Instantiate(scorePrefab, new Vector3(520f, 1850f, 0f), Quaternion.identity);
        Text.transform.SetParent(Canvas.transform);
        completeText.SetActive(true);
        yield return new WaitForSeconds(2f);
        completeText.SetActive(false);

       


        Destroy(this);
         }
    }

}
