using UnityEngine;

public class CloseInteractable : MonoBehaviour
{
    private ToggleObjectCanvas canvasToggle;

    public AudioSource objectAudio;
    public AudioClip journalClosing;
    
    void Start()
    {
        canvasToggle = GetComponentInParent<ToggleObjectCanvas>();
    }

    public void Toggle()
    {
        canvasToggle.ToggleCanvas();

        objectAudio.clip = journalClosing;
        objectAudio.Play();
    }
}
