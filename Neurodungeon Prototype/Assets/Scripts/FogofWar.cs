using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogofWar : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag ("Player"))
        {
            Score.score += 5;
            Destroy(gameObject);
        }
    }
}
