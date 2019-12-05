using UnityEngine;

public class ToggleObjectCanvas : MonoBehaviour
{
    private Canvas _infoCanvas;
    public GameObject marking;
    
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
        }
        
        else if (_infoCanvas.enabled == true)
        {
            _infoCanvas.enabled = false;
        }
    }

    public void removeMarking()
    {

        Destroy(marking);

    }

}
