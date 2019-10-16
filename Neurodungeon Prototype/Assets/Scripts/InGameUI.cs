using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameUI : MonoBehaviour
{
   public Animator cameraanim;
   public Animator black;
    public GameObject UI;

    void Start()
    {
        
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
        yield return new WaitForSeconds(3f);
        cameraanim.SetBool("onback", false);
        black.SetBool("onback", false);
        SceneManager.LoadScene("MainMenu");

    }
}
