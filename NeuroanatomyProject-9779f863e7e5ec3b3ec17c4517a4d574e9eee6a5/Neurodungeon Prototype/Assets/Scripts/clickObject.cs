using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickObject : MonoBehaviour
{
    public Material hitMaterial;

    public ButtonScript bS;
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
            if (Physics.Raycast(ray, out hitInfo))
            {
                var rig = hitInfo.collider;
                if(rig.CompareTag("Interactable"))
                {
                    rig.GetComponent<MeshRenderer>().material = hitMaterial;
                    qIndexScript = rig.GetComponent<QuestionIndexer>();
                    Debug.Log(rig.name);
                    bS.OpenQuestion1(qIndexScript.questionIndex);
                }
            }
        }

    }
}
