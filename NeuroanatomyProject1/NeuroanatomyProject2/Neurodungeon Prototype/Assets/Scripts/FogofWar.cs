using UnityEngine;

public class FogofWar : MonoBehaviour
{

    public GameObject Canvas;
    public GameObject scorePrefab;

    private void OnTriggerEnter(Collider collision)
    {
        //Checks for player collision on fog pieces, if yes, it destroys the fog and gives score
        if (collision.gameObject.CompareTag ("Player"))
        {
            Score.score += 5;

            GameObject Text = Instantiate(scorePrefab, new Vector3(520f, 1850f, 0f), Quaternion.identity);
            Text.transform.SetParent(Canvas.transform);

            Destroy(gameObject);
        }
    }
}
