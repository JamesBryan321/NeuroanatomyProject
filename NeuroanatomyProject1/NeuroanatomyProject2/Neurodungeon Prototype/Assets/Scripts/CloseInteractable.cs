using UnityEngine;

public class CloseInteractable : MonoBehaviour
{
    private ToggleObjectCanvas canvasToggle;

    public AudioSource objectAudio;
    public AudioClip journalClosing;
    private GameObject player;
    private Player playerScript;

    void Start()
    {
        canvasToggle = GetComponentInParent<ToggleObjectCanvas>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<Player>();
    }

    public void Toggle(bool activateinteraction)
    {
        if (activateinteraction == true)
        {
            playerScript.UnlockJoystick();
        }
        else if (activateinteraction == false)
        {
            clickObject.canInteract = false;
        }
        canvasToggle.ToggleCanvas();
        objectAudio.clip = journalClosing;
        objectAudio.volume = 0.28f;
        objectAudio.Play();
    }
}
