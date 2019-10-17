using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameUI : MonoBehaviour
{
    public Animator cameraanim;
    public Animator black;
    public GameObject UI;
    public GameObject questbook;

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

    void Update()
    {
        
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
