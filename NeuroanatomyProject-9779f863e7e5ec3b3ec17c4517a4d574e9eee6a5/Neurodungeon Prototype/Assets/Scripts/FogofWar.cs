using UnityEngine;

public class FogofWar : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        //Checks for player collision on fog pieces, if yes, it destroys the fog and gives score
        if (collision.gameObject.CompareTag ("Player"))
        {
            Score.score += 5;
            Destroy(gameObject);
        }
    }
}
