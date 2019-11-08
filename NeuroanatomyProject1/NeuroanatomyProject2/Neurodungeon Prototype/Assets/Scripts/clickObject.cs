using UnityEngine;

public class clickObject : MonoBehaviour
{
    public Material hitMaterial;
    public InGameUI UI;
    public ToggleObjectCanvas canvasToggle;
    public GameObject clickedObject;


    void Update () 
    {
        //Checks if player clicks on interactable objects
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            //int layer_mask = LayerMask.GetMask("Interactable"); this variable shouldn't be necessary?
            if (Physics.Raycast(ray, out hitInfo, 1000/*, layer_mask*/))
            {
                var rig = hitInfo.collider;
                if(rig.CompareTag("Interactable"))
                {
                    canvasToggle = rig.GetComponent<ToggleObjectCanvas>();
                    Debug.Log(rig.name);
                    canvasToggle.ToggleCanvas();
                }
                else
                {
                    {
                        Debug.Log(rig.name);
                    }
                }
            }
        }

    }
}
