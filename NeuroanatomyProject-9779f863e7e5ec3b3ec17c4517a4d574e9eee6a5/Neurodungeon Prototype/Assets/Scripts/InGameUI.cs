using System.Collections;
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
        //Starts coroutine which turns on UI after transition animation
        StartCoroutine("OnGameStart");
    }

    IEnumerator OnGameStart()
    {
        yield return new WaitForSeconds(1f);
        UI.SetActive(true);
    }

    public void OnBack ()
    {
        //Starts transition back to main menu
        StartCoroutine("BackToMenu");
    }

    public void OnRightAnswer ()
    {
        //This handles the "right answer" effect 
        Score.score += 25;
        door.SetBool("opendoor", true);
    }
    void Update()
    {
        //Updates score UI
        scoretext.text = "Score: " + Score.score;
    } 

    IEnumerator BackToMenu ()
    {
        //Since this handles scene transition, any sound effects should go here
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
