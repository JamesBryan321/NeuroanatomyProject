using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public Transform target;
    public float rotatespeed;
    public Animator anim;
    public GameObject UI;

    bool enteringScene;

    public AudioSource camAudio;
    public AudioSource buttonAudio;

    void Start()
    {
        //Starts a coroutine which turns on UI after the menu opening animation
        StartCoroutine("OnMenuStart");

        enteringScene = false;
    }

    IEnumerator OnMenuStart ()
    {
        yield return new WaitForSeconds(1f);
        UI.SetActive(true);
    }
    public void OnEnter ()
    {
        //Starts scene transition
        StartCoroutine("SceneChange");

        buttonAudio.Play();
        enteringScene = true;

    }

    void Update()
    {
        //Forces camera to look and rotate around the brain
            transform.LookAt(target);
            transform.Translate(Vector3.right * rotatespeed * Time.deltaTime);

        if (enteringScene == true)
        {

            camAudio.volume -= 0.001f;

        }

    }

    IEnumerator SceneChange ()
    {
        //Scene transition stuff happens here, sound effects should be added here
        anim.SetBool ("changescene", true);
        UI.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        anim.SetBool("changescene", false);
        SceneManager.LoadScene("MainGame");
    }
}
