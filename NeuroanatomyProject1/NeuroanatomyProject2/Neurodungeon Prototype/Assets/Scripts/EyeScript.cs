using UnityEngine;

public class EyeScript : MonoBehaviour
{
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        transform.right = player.transform.position - transform.position;
    }
}
