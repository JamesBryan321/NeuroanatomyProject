using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;
public class InGameUI : MonoBehaviour
{
    //Audioclips
    public AudioClip journalOpening;
    public AudioClip journalClosing;
    public AudioClip rightAnswer;
    public AudioClip wrongAnswer;
    public AudioClip pageTurning;
    //GameObjects
    public GameObject prisoner1;
    public GameObject prisonCell1;
    public GameObject UI;
    public GameObject ingamemenu;
    public GameObject MenuButton;
    public GameObject MapButton;
    public GameObject question1;
    public GameObject question2;
    public GameObject clue1;
    public GameObject WikiButton;
    public GameObject RevisionButton;
    public GameObject Canvas;
    public GameObject scorePlusPrefab;
    public GameObject scoreMinusPrefab;

    /*public RemoveMarking markingCanvasScript;*/

    //Images
    public Image joystickOuter, joystickInner, joystickInvisible;

    public Canvas v1Index;
    public Canvas v2Index;

    //Animators
    public Animator p1Animator;
    public Animator prisonCell1Animator;
    public Animator cameraanim;
    public Animator black;
    public Animator door;

    public Animator currentAnimator;
    //Audiosources
    AudioSource myAudio;
    public AudioSource answersAudio;
    //Texts
    public TextMeshProUGUI scoretext;
    //Booleans
   
    //Floats 
    public float audioVolume;

    GameObject[] activetutorials;

    public GameObject comboScore;

    public SceneAudioVolumeScript scriptA;

    public PopUpController popups;
    public List<GameObject> activepopups = new List<GameObject>();
    public Canvas[] activecanvases;
    public Player playerjoystick;
    public Canvas place;

    public static GameObject[] playerpositions;

    public void Start()
    {
        //Initialises things when opening the scene
        StartCoroutine("OnGameStart");

        question1.SetActive(false);
        question2.SetActive(false);
        clue1.SetActive(false);

        p1Animator = prisoner1.GetComponent<Animator>();
        prisonCell1Animator = prisonCell1.GetComponent<Animator>();
        
        myAudio = GetComponent<AudioSource>();

        comboScore = GameObject.Find("GameManagement");

        joystickOuter.enabled = true;
        joystickInner.enabled = true;
        joystickInvisible.enabled = false;
        

    }
    Canvas[] FindCanvasWithLayer(int layer) {
        Canvas[] goArray = FindObjectsOfType(typeof(Canvas)) as Canvas[];
        List <Canvas> goList = new List<Canvas>();
        for (int i = 0; i < goArray.Length; i++) {
            if (goArray[i].gameObject.layer == layer && goArray [i].enabled == true) {
                goList.Add(goArray[i]); 
            }
        }
        if (goList.Count == 0) {
            goList.Add(place);
        }
        return goList.ToArray();
    }
    public void OpenMenu()
    {
        //Handles the in game menu that can be opened anytime
            
            if (ingamemenu.activeSelf == false)
            {
              activecanvases = FindCanvasWithLayer(5);
                for (int i = 0; i < activecanvases.Length; i++)
                {
                activecanvases[i].enabled = false;
                }           
            for (int i = 0; i < popups.popUps.Length; i++)
            {
                if (popups.popUps [i].activeSelf == true)
                {
                    activepopups.Add(popups.popUps[i]);
                    popups.popUps[i].SetActive (false);
                }
            }           
                clickObject.canInteract = false;
                ingamemenu.SetActive (true);
                OnMapButton();
                JournalOpeningSound();
                AmbienceVolumeLower();
        }
            else if (ingamemenu.activeSelf == true)
            {
                foreach (GameObject popup in activepopups)
                {
                  popup.SetActive(true);
                }
                     for (int i = 0; i < activecanvases.Length; i++)
                     {
                       activecanvases[i].enabled = true;
                       activecanvases[i] = null;
                     }
                activepopups.Clear();
                ingamemenu.SetActive (false);
                v1Index.enabled = false;
                v2Index.enabled = false;
                clue1.SetActive(false);
                JournalClosingSound();
                AmbienceVolumeHigher();
                clickObject.canInteract = true;
                playerjoystick.UnlockJoystick();
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
        answersAudio.volume = 0.12f;
        answersAudio.clip = rightAnswer;
        answersAudio.Play();
        Score.score += 25;
        GameObject Text = Instantiate(scorePlusPrefab, new Vector3(0f, 890f, 0f), Quaternion.identity);
        Text.transform.SetParent(Canvas.transform, false);
        currentAnimator.SetBool("Correct", true);
        comboScore.GetComponent<ComboScoreEarner>().questionPlusCombo();
    }
    public void OnWrongAnswer()
    {
        //Handles the wrong answers
        answersAudio.volume = 0.35f;
        answersAudio.clip = wrongAnswer;
        answersAudio.Play();
        Score.score -= 25;
        GameObject Text = Instantiate(scoreMinusPrefab, new Vector3(0f, 890f, 0f), Quaternion.identity);
        Text.transform.SetParent(Canvas.transform, false);
        comboScore.GetComponent<ComboScoreEarner>().questionMinusCombo();
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
            
            RevisionButton.SetActive(false);
            MenuButton.SetActive(true);
            WikiButton.SetActive(false);
            v1Index.enabled = false;
            v2Index.enabled = false;
            PageTurningSound();
            MapButton.SetActive(false);
        }
    }

    public void OnMapButton()
    {
        //Handles the "map" section on in game ui
        if (MapButton.activeSelf == false)
        {
            RevisionButton.SetActive(false);
            MenuButton.SetActive(false);
            WikiButton.SetActive(false);
            v1Index.enabled = false;
            v2Index.enabled = false;
            PageTurningSound();
            MapButton.SetActive(true);
        }
    }

    public void OnWikiButton()
    {
        //Handles the "wiki" section on in game ui
        if (WikiButton.activeSelf == false)
        {
            MapButton.SetActive(false);
            RevisionButton.SetActive(false);
            WikiButton.SetActive(true);
            MenuButton.SetActive(false);
            v1Index.enabled = false;
            v2Index.enabled = false;
            PageTurningSound();
            WikiButton.SetActive(true);
        }
    }

    public void OnRevision ()
    {
        RevisionButton.SetActive(true);
        WikiButton.SetActive(false);
        MenuButton.SetActive(false);
        v1Index.enabled = false;
        v2Index.enabled = false;
        PageTurningSound();
        WikiButton.SetActive(false);
    }

    public void OnIndexButton1()
    {
        //Handles the "map" section on in game ui
        if (v1Index.enabled == false)
        {
            RevisionButton.SetActive(false);
            WikiButton.SetActive(false);
            MenuButton.SetActive(false);
            MapButton.SetActive(false);
            v2Index.enabled = false;
            PageTurningSound();
            v1Index.enabled = true;
        }
    }
    
    public void OnIndexButton2()
    {
        //Handles the "map" section on in game ui
        if (v2Index.enabled == false)
        {
            RevisionButton.SetActive(false);
            WikiButton.SetActive(false);
            MenuButton.SetActive(false);
            MapButton.SetActive(false);
            v1Index.enabled = false;
            PageTurningSound();
            v2Index.enabled = true;
        }
    }



    //Various sound functions
    void AmbienceVolumeLower()
    {

        scriptA.LowerAudio();

    }

    void AmbienceVolumeHigher()
    {

        scriptA.HigherAudio();

    }

    void JournalOpeningSound()
    {

        myAudio.pitch = 1f;
        myAudio.volume = 1f;
        myAudio.clip = journalOpening;
        myAudio.Play();

    }

    void JournalClosingSound()
    {

        myAudio.pitch = 1f;
        myAudio.volume = 0.34f;
        myAudio.clip = journalClosing;
        myAudio.Play();

    }

    void PageTurningSound()
    {

        myAudio.pitch = 1f;
        myAudio.volume = 0.4f;
        myAudio.clip = pageTurning;
        myAudio.Play();

    }

    public void JoystickVisible()
    {

        joystickOuter.enabled = true;
        joystickInner.enabled = true;
        joystickInvisible.enabled = false;

    }

    public void JoystickInvisible()
    {

        joystickOuter.enabled = false;
        joystickInner.enabled = false;
        joystickInvisible.enabled = true;

    }

}
