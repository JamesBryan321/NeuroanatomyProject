using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseInteractable : MonoBehaviour
{
    private ToggleObjectCanvas canvasToggle;
    
    void Start()
    {
        canvasToggle = GetComponentInParent<ToggleObjectCanvas>();
    }

    public void Toggle()
    {
        canvasToggle.ToggleCanvas();
    }
}
