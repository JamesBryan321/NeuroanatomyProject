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

    void Update () 
    {
        //print(canInteract);
        if (canInteract == true) { 
        //Checks if player clicks on interactable objects
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            int layer_mask = LayerMask.GetMask("Interactable");
            if (Physics.Raycast(ray, out hitInfo, 1000, layer_mask))
            {
                var rig = hitInfo.collider;
                if(rig.CompareTag("Interactable"))
                {
                    canvasToggle = rig.GetComponent<ToggleObjectCanvas>();
                    Debug.Log(rig.name);
                    canvasToggle.ToggleCanvas();

                    objectAudio.clip = journalOpening;
                    objectAudio.Play();
                    
                    UI.currentAnimator = rig.GetComponent<Animator>();

                    markingCanvasScript = rig.GetComponentInChildren<RemoveMarking>();
                    markingCanvasScript.DestroyMarking();
                }

                if (pUController.interactableHintInteger == 1)
                {
                    pUController.CloseInteractableHint();
                }
            }
        }
       }
    }
}
