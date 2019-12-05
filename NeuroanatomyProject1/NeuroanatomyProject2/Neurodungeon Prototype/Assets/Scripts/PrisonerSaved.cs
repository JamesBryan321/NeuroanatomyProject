using UnityEngine;

public class PrisonerSaved : MonoBehaviour
{
    public Transform waypoint;
    public GameObject Smoke;
    public GameObject mainRoomAudio;
    AudioSource myAudio;
    public GameObject escapeAudioPrefab;

    private Collider myCollider;
    
    private Animator prisonerAnimator;

    private void Start()
    {
        mainRoomAudio.SetActive(false);
        myAudio = GetComponent<AudioSource>();
        myCollider = GetComponent<Collider>();
            }

    public void Dance()
    {
        
        prisonerAnimator = this.gameObject.GetComponent<Animator>();
        prisonerAnimator.SetBool("Dance", true);
    }
    
    public void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(escapeAudioPrefab, transform.position, transform.rotation);
            Instantiate(Smoke, transform.position, transform.rotation);
            transform.position = waypoint.position;

            mainRoomAudio.SetActive(true);
            myAudio.enabled = false;
            myCollider.enabled = false;
            
        }
    }
}
