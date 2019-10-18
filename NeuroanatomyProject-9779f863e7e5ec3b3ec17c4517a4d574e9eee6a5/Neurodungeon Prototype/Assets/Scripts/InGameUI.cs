using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class InGameUI : MonoBehaviour
{
    public Animator cameraanim;
    public Animator black;
    public GameObject UI;
    public GameObject questbook;
    public TextMeshProUGUI scoretext;
    public Animator door;

    void Start()
    {
        StartCoroutine("OnGameStart");
    }

    IEnumerator OnGameStart()
    {
        yield return new WaitForSeconds(1f);
        UI.SetActive(true);
    }

    public void OnBack ()
    {
        StartCoroutine("BackToMenu");
    }

    public void OnRightAnswer ()
    {
        Score.score += 25;
        door.SetBool("opendoor", true);
    }
    void Update()
    {
        scoretext.text = "Score: " + Score.score;
    } 

    IEnumerator BackToMenu ()
    {
        cameraanim.SetBool("onback", true);
        black.SetBool("onback", true);
        UI.SetActive(false);
        if (questbook.activeSelf == true)
        {
            questbook.SetActive(false);
        }
        yield return new WaitForSeconds(3f);
        cameraanim.SetBool("onback", false);
        black.SetBool("onback", false);
        SceneManager.LoadScene("MainMenu");

    }
}
