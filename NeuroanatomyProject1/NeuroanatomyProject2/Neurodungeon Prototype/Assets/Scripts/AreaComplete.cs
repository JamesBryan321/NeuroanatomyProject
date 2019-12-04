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

    public GameObject comboScore;

    bool pointsgiven = false;

    private void Start()
    {
        comboScore = GameObject.Find("GameManagement");
    }

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

        comboScore.GetComponent<ComboScoreEarner>().areaCombo();

    }

    IEnumerator TextUI ()
    {
    if (pointsgiven == false) {
        pointsgiven = true;
        Score.score += 200;
            GameObject Text = Instantiate(scorePrefab, new Vector3(0f, 890f, 0f), Quaternion.identity);
            Text.transform.SetParent(Canvas.transform, false);
            completeText.SetActive(true);
        yield return new WaitForSeconds(2f);
        completeText.SetActive(false);

       


        Destroy(this);
         }
    }

}
