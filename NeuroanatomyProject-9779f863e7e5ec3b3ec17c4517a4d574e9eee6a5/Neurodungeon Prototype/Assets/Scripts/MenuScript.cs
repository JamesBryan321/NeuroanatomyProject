using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public Transform target;
    public float rotatespeed;
    public Animator anim;
    public GameObject UI;

    void Start()
    {
        StartCoroutine("OnMenuStart");
    }

    IEnumerator OnMenuStart ()
    {
        yield return new WaitForSeconds(1f);
        UI.SetActive(true);
    }
    public void OnEnter ()
    {
        StartCoroutine("SceneChange");
    }

    void Update()
    {
            transform.LookAt(target);
            transform.Translate(Vector3.right * rotatespeed * Time.deltaTime);
    }

    IEnumerator SceneChange ()
    {
        anim.SetBool ("changescene", true);
        UI.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        anim.SetBool("changescene", false);
        SceneManager.LoadScene("MainGame");
    }
}
