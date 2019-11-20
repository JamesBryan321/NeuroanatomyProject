using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderValueText : MonoBehaviour
{

    public Slider slider;

    public TextMeshProUGUI sliderValueText;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        sliderValueText.text = slider.value.ToString();

    }
    

}
