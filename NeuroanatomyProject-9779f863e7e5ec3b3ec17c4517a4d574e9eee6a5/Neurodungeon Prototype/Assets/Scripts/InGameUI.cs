using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;
public class InGameUI : MonoBehaviour
{
    //Audioclips
    public AudioClip journalOpening;
    public AudioClip journalClosing;
    public AudioClip rightAnswer;
    public AudioClip wrongAnswer;
    //GameObjects
    public GameObject prisoner1;
    public GameObject prisonCell1;
    public GameObject UI;
    public GameObject ingamemenu;
    public GameObject MenuButton;
    public GameObject MapButton;
    public GameObject question1;
    public GameObject question2;
    //Animators
    public Animator p1Animator;
    public Animator prisonCell1Animator;
    public Animator cameraanim;
    public Animator black;
    public Animator door;
    //Audiosources
    AudioSource myAudio;
    //Texts
    public TextMeshProUGUI scoretext;
    //Booleans
    bool rightanswer = false;



    public void Start()
    {
        //Initialises things when opening the scene
        StartCoroutine("OnGameStart");

        question1.SetActive(false);
        question2.SetActive(false);

        p1Animator = prisoner1.GetComponent<Animator>();
        prisonCell1Animator = prisonCell1.GetComponent<Animator>();
        
        myAudio = GetComponent<AudioSource>();
        
    }
    
    public void OpenMenu()
    {
        //Handles the in game menu that can be opened anytime
       
            if (ingamemenu.activeSelf == false)
            {
                ingamemenu.SetActive (true);
                OnMapButton();
                myAudio.clip = journalOpening;
                myAudio.Play();
            }
            else if (ingamemenu.activeSelf == true)
            {
                ingamemenu.SetActive (false);
                myAudio.clip = journalClosing;
                myAudio.Play();
            }
    }

    public void OpenQuestion(int questionIndex)
    {
        //Handles the questions asked when interacting with game world
        if (questionIndex == 1)
        {
            if (question1.activeSelf == false)
            {
                question1.SetActive(true);
                myAudio.clip = journalOpening;
                myAudio.Play();
            }
            else if (question1.activeSelf == true)
            {
                question1.SetActive(false);
                myAudio.clip = journalClosing;
                myAudio.Play();
            }
        }
        
        if (questionIndex == 2)
        {
            if (question2.activeSelf == false)
            {
                question2.SetActive(true);
                myAudio.clip = journalOpening;
                myAudio.Play();
            }
            else if (question2.activeSelf == true)
            {
                question2.SetActive(false);
                myAudio.clip = journalClosing;
                p1Animator.SetBool("Correct", true);
                prisonCell1Animator.SetBool("Correct", true);
                myAudio.Play();
            }
        }
    }

    IEnumerator OnGameStart()
    { 
        //Handles game transition
        yield return new WaitForSeconds(1f);
        UI.SetActive(true);
    }

    public void OnBack()
    {
        //Starts transition back to main menu
        StartCoroutine("BackToMenu");
    }

    public void OnRightAnswer()
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

    IEnumerator BackToMenu()
    {
        //Since this handles scene transition, any sound effects should go here
        cameraanim.SetBool("onback", true);
        black.SetBool("onback", true);
        UI.SetActive(false);
        if (ingamemenu.activeSelf == true)
        {
            ingamemenu.SetActive(false);
        }
        yield return new WaitForSeconds(3f);
        cameraanim.SetBool("onback", false);
        black.SetBool("onback", false);
        SceneManager.LoadScene("MainMenu");

    }

    public void OnMenuButton()
    {
        //Handles the "menu" section on in game ui
        if (MenuButton.activeSelf == false)
        {
            MenuButton.SetActive(true);
            MapButton.SetActive(false);
        }
    }

    public void OnMapButton()
    {
        //Handles the "map" section on in game ui
        if (MapButton.activeSelf == false)
        {
            MenuButton.SetActive(false);
            MapButton.SetActive(true);
        }
    }

    public void OnWrongAnswer()
    {
        //Handles the wrong answers
        myAudio.clip = wrongAnswer;
        myAudio.Play();
        Score.score -= 25;
    }
}
