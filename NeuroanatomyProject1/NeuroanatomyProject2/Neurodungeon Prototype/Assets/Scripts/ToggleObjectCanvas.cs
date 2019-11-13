using UnityEngine;

public class ToggleObjectCanvas : MonoBehaviour
{
    private Canvas _infoCanvas;
    
    private void Start()
    {
        _infoCanvas = GetComponentInChildren<Canvas>();
        _infoCanvas.enabled = false;
    }

    public void ToggleCanvas()
    {
        if (_infoCanvas.enabled == false)
        {
            _infoCanvas.enabled = true;
            clickObject.canInteract = false;
        }
        
        else if (_infoCanvas.enabled == true)
        {
            _infoCanvas.enabled = false;
            clickObject.canInteract = true;
        }
    }
}
