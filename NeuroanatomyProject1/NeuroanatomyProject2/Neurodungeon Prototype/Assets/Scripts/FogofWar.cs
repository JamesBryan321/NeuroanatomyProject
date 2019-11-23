using UnityEngine;

public class FogofWar : MonoBehaviour
{

    public GameObject Canvas;
    public GameObject scorePrefab;

    private void OnTriggerEnter(Collider collision)
    {
        //Checks for player collision on fog pieces, if yes, it destroys the fog and gives score
        if (collision.gameObject.CompareTag ("Player"))
        {
            

            

            Destroy(gameObject);
        }
    }
}
