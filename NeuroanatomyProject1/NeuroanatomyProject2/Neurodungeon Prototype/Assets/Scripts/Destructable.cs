using UnityEngine;

public class Destructable : MonoBehaviour
{

    public GameObject Destroyedversion;
    public GameObject Canvas;
    public GameObject scorePrefab;
    public GameObject comboScore;


    /*private void OnMouseDown()
    {
        Instantiate(Destroyedversion, transform.position, transform.rotation);
        Score.score += 5;
        GameObject Text = Instantiate(scorePrefab, new Vector3(520f, 1850f, 0f), Quaternion.identity);
        Text.transform.SetParent(Canvas.transform);
        Destroy(gameObject);
    }*/

    private void Start()
    {
        comboScore = GameObject.Find("GameManagement");
    }

    public void Break()
    {
        Instantiate(Destroyedversion, transform.position, transform.rotation);
        Destroy(gameObject);
        Score.score += 5;
        comboScore.GetComponent<ComboScoreEarner>().destructableCombo();
        GameObject Text = Instantiate(scorePrefab, new Vector3(0f, 890f, 0f), Quaternion.identity);
        Text.transform.SetParent(Canvas.transform, false);

    }
}
