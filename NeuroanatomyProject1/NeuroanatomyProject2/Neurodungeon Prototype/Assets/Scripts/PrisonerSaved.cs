using UnityEngine;

public class PrisonerSaved : MonoBehaviour
{
    public Transform waypoint;

    public void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transform.position = waypoint.position;
        }
    }
}
