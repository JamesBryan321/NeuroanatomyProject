using UnityEngine;

public class clickObject : MonoBehaviour
{
    public Material hitMaterial;
    public InGameUI UI;
    public ToggleObjectCanvas canvasToggle;
    public GameObject clickedObject;
    public RemoveMarking markingCanvasScript;
    public PopUpController pUController;
    public AudioSource objectAudio;
    public AudioClip journalOpening;
    public static bool canInteract = true;
    public Player playerScript;
    public Destructable destructableScript;
    public BrainScript brainScript;

    void Update () 
    {
        print(canInteract);
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Input.GetMouseButtonDown(0))
        {
            if (canInteract == true) { 
        //Checks if player clicks on interactable objects

            int layer_mask = LayerMask.GetMask("Interactable");
            int destructableMask = LayerMask.GetMask("Destructable");
            int brainMask = LayerMask.GetMask("Brain");
            if (Physics.Raycast(ray, out hitInfo, 1000, layer_mask))
            {
                var rig = hitInfo.collider;
                if(rig.CompareTag("Interactable"))
                {
                    canvasToggle = rig.GetComponent<ToggleObjectCanvas>();
                    canvasToggle.ToggleCanvas();
                    playerScript.LockJoystick();

                    objectAudio.clip = journalOpening;
                        objectAudio.volume = 0.542f;
                    objectAudio.Play();
                    
                    UI.currentAnimator = rig.GetComponent<Animator>();

                    markingCanvasScript = rig.GetComponentInChildren<RemoveMarking>();
                    /*markingCanvasScript.DestroyMarking();*/
                }

                if (pUController.interactableHintInteger == 1)
                {
                    pUController.CloseInteractableHint();
                    playerScript.UnlockJoystick();
                }
            }

            if (Physics.Raycast(ray, out hitInfo, 1000, destructableMask))
            {
                var rig = hitInfo.collider;
                destructableScript = rig.GetComponent<Destructable>();
                destructableScript.Break();
            }

                if (Physics.Raycast(ray, out hitInfo, 1000, brainMask))
                {

                    var rig = hitInfo.collider;
                    brainScript = rig.GetComponent<BrainScript>();
                    brainScript.BrainHit();
                    
                }
                }
            int tutorialMask = LayerMask.GetMask("Tutorial");
            if (Physics.Raycast(ray, out hitInfo, 1000, tutorialMask))
            {
                var rig = hitInfo.collider;
                if (rig.CompareTag("Interactable"))
                {
                    canvasToggle = rig.GetComponent<ToggleObjectCanvas>();
                    canvasToggle.ToggleCanvas();
                    playerScript.LockJoystick();

                    objectAudio.clip = journalOpening;
                    objectAudio.volume = 0.42f;
                    objectAudio.Play();

                    UI.currentAnimator = rig.GetComponent<Animator>();

                    markingCanvasScript = rig.GetComponentInChildren<RemoveMarking>();
                    /*markingCanvasScript.DestroyMarking();*/
                }

                if (pUController.interactableHintInteger == 1)
                {
                    pUController.CloseInteractableHint();
                    playerScript.UnlockJoystick();
                }
            }
        }
    }
}
