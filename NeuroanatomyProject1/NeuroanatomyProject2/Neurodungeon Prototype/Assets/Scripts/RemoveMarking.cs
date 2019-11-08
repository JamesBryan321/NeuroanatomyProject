using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveMarking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DestroyMarking()
    {
        Destroy(this.gameObject);
    }
}
