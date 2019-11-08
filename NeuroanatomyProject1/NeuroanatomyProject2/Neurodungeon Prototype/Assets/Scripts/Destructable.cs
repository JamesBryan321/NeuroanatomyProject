using UnityEngine;

public class Destructable : MonoBehaviour
{

    public GameObject Destroyedversion;

    private void OnMouseDown()
    {
        Instantiate(Destroyedversion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
