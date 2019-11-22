using UnityEngine;

public class Destructable : MonoBehaviour
{

    public GameObject Destroyedversion;
    public GameObject Canvas;
    public GameObject scorePrefab;


    /*private void OnMouseDown()
    {
        Instantiate(Destroyedversion, transform.position, transform.rotation);
        Score.score += 5;
        GameObject Text = Instantiate(scorePrefab, new Vector3(520f, 1850f, 0f), Quaternion.identity);
        Text.transform.SetParent(Canvas.transform);
        Destroy(gameObject);
    }*/

    public void Break()
    {
        Debug.Log("Boom!");
        Instantiate(Destroyedversion, transform.position, transform.rotation);
        Score.score += 5;
        GameObject Text = Instantiate(scorePrefab, new Vector3(520f, 1850f, 0f), Quaternion.identity);
        Text.transform.SetParent(Canvas.transform);
        Destroy(gameObject);
    }
}
