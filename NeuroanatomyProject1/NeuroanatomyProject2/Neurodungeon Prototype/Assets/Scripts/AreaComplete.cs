using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaComplete : MonoBehaviour
{
    public List<GameObject> fogs = new List<GameObject>();
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fog")
        {
            fogs.Add(other.gameObject);
        }
    }

    private void Update()
    {
        fogs.RemoveAll(GameObject => GameObject == null);
        if (fogs.Count == 0)
        {
            Score.score += 200;
            //Chris add sfx here
            Destroy(this);
        }
    }
}
