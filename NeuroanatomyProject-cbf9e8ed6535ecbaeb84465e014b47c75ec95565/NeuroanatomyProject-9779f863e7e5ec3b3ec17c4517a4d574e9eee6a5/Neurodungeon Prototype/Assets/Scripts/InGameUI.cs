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
    public GameObject QuestionButton;
    public GameObject MenuButton;
    public GameObject MapButton;
    bool rightanswer = false;

    AudioSource myAudio;

    public AudioClip rightAnswer;
    public AudioClip wrongAnswer;

    void Start()
    {
        //Starts coroutine which turns on UI after transition animation
        StartCoroutine("OnGameStart");
        myAudio = GetComponent<AudioSource>();
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
        if (rightanswer == false)
        {
            Score.score += 25;
            door.SetBool("opendoor", true);
            rightanswer = true;
            myAudio.clip = rightAnswer;
            myAudio.Play();
        }
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

    public void OnQuestionButton () 
    {
        if (QuestionButton.activeSelf == false)
        {
            MenuButton.SetActive(false);
            MapButton.SetActive(false);
            QuestionButton.SetActive(true);
        }
    }

    public void OnMenuButton()
    {
        if (MenuButton.activeSelf == false)
        {
            MenuButton.SetActive(true);
            MapButton.SetActive(false);
            QuestionButton.SetActive(false);
        }
    }

    public void OnMapButton()
    {
        if (MapButton.activeSelf == false)
        {
            MenuButton.SetActive(false);
            MapButton.SetActive(true);
            QuestionButton.SetActive(false);
        }
    }

    public void OnWrongAnswer ()
    {
        myAudio.clip = wrongAnswer;
        myAudio.Play();
        Score.score -= 25;
    }
}
