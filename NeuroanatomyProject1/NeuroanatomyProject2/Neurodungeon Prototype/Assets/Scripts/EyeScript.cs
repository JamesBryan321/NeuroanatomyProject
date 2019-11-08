using UnityEngine;

public class EyeScript : MonoBehaviour
{
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector3 difference = player.transform.position - transform.position;
        float rotationY = Mathf.Atan2(difference.x, difference.z) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, rotationY - 90f, 0.0f);
    }
}
