using UnityEngine;

public class PrisonerSaved : MonoBehaviour
{
    public Transform waypoint;
    
    private Animator prisonerAnimator;

    public void Dance()
    {
        
        prisonerAnimator = this.gameObject.GetComponent<Animator>();
        prisonerAnimator.SetBool("Dance", true);
    }
    
    public void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transform.position = waypoint.position;
        }
    }
}
