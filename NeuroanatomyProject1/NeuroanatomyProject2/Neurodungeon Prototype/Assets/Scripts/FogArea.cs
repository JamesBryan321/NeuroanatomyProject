using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogArea : MonoBehaviour
{
    public TorchScript torch;
 
    void OnTriggerEnter(Collider other)
    {
        GameObject ontrigger = other.gameObject;

            if (other.gameObject.CompareTag("Fog"))
            {
             torch.fogs.Add(ontrigger);
            }
    }
}
