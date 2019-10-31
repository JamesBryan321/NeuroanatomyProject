using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickObject : MonoBehaviour
{
    public Material hitMaterial;

    public InGameUI UI;
    public QuestionIndexer qIndexScript;

    // Use this for initialization
    void Start () {

    }
	
    // Update is called once per frame
    void Update () 
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            int layer_mask = LayerMask.GetMask("Interactable");
            if (Physics.Raycast(ray, out hitInfo, 1000, layer_mask))
            {
                var rig = hitInfo.collider;
                if(rig.CompareTag("Interactable"))
                {
                   //rig.GetComponent<MeshRenderer>().material = hitMaterial;
                    qIndexScript = rig.GetComponent<QuestionIndexer>();
                    Debug.Log(rig.name);
                    UI.OpenQuestion(qIndexScript.questionIndex);
                }
            }
        }

    }
}
