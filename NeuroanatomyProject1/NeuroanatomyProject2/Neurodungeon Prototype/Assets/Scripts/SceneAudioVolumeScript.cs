using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneAudioVolumeScript : MonoBehaviour
{

    public bool lowerAudio;

    public float audioVolume;

    public Slider Volume;

    // Start is called before the first frame update
    void Start()
    {

        lowerAudio = false;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (lowerAudio == false)
        {

            AudioListener.volume = Volume.value;

        }
        else if (lowerAudio == true)
        {

            AudioListener.volume = Volume.value * 0.3f;

        }

    }

    /*
    public void AdjustVolume(float vol)
    {

        
        audioVolume = vol;
   
        if (lowerAudio == false)
        {

            AudioListener.volume = audioVolume;

        }
        else if (lowerAudio == true)
        {

            AudioListener.volume = audioVolume * 0.3f;

        }
        

    }
    */
    public void LowerAudio()
    {

        lowerAudio = true;

    }

    public void HigherAudio()
    {

        lowerAudio = false;

    }
    

}
