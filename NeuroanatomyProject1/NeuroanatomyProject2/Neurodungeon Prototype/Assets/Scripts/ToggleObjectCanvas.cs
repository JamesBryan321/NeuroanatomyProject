using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObjectCanvas : MonoBehaviour
{
    private Canvas _infoCanvas;
    
    private void Start()
    {
        _infoCanvas = GetComponentInChildren<Canvas>();
        _infoCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
