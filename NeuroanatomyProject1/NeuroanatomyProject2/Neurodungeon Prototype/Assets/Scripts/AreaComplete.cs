using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class AreaComplete : MonoBehaviour
{

    public AudioSource gameManagementAudio;

    public AudioClip scoreSound;

    public List<GameObject> fogs = new List<GameObject>();
    public GameObject completeText;

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
            Score.score += 200;

            playScoreSound();

            StartCoroutine("TextUI");

            Destroy(this);
        }
    }

    void playScoreSound()
    {

        gameManagementAudio.volume = 0.16f;
        gameManagementAudio.clip = scoreSound;
        gameManagementAudio.Play();

    }

    IEnumerator TextUI ()
    {
        completeText.SetActive(true);
        yield return new WaitForSeconds(2f);
        completeText.SetActive(false);
    }

}
