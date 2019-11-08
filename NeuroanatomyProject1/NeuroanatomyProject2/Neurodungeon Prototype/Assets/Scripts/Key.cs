using UnityEngine;

public class Key : MonoBehaviour
{
    public Animator anim;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            anim.SetBool("opendoor", true);
            Destroy(gameObject);
        }
    }

}
