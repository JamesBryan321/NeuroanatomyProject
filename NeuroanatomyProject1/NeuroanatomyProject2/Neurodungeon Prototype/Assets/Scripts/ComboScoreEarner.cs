using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboScoreEarner : MonoBehaviour
{

    public float destructablesScore;
    public float torchScore;
    public float areaScore;
    public float questionScore;
    public float dScoreA;
    public float tScoreA;
    public float aScoreA;
    public float qScoreA;

    public GameObject dText;
    public GameObject tText;
    public GameObject aText;
    public GameObject qText;

    public GameObject dAchievement;
    public GameObject tAchievement;
    public GameObject aAchievement;
    public GameObject qAchievement;

    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {

        destructablesScore = 0f;
        torchScore = 0f;
        areaScore = 0f;
        questionScore = 0f;

    }

    // Update is called once per frame
    public void Update()
    {
        
        if (destructablesScore >= 7f)
        {
            GameObject Text = Instantiate(dText, new Vector3(0f, 220f, 0f), Quaternion.identity);
            Text.transform.SetParent(Canvas.transform, false);
            Score.score += 50;
            destructablesScore = 0f;
        }

        if (torchScore >= 5f)
        {
            GameObject Text = Instantiate(tText, new Vector3(0f, 220f, 0f), Quaternion.identity);
            Text.transform.SetParent(Canvas.transform, false);
            Score.score += 75;
            torchScore = 0f;
        }

        if (areaScore >= 1f)
        {
            GameObject Text = Instantiate(aText, new Vector3(0f, 220f, 0f), Quaternion.identity);
            Text.transform.SetParent(Canvas.transform, false);
            Score.score += 100;
            areaScore = 0f;
        }

        if (questionScore >= 3f)
        {
            GameObject Text = Instantiate(qText, new Vector3(0f, 220f, 0f), Quaternion.identity);
            Text.transform.SetParent(Canvas.transform, false);
            Score.score += 100;
            questionScore = 0f;
        }

        if (questionScore <= -1f)
        {
            questionScore = 0f;
        }

        if (dScoreA == 45f)
        {
            GameObject Text = Instantiate(dAchievement, new Vector3(0f, 430f, 0f), Quaternion.identity);
            Text.transform.SetParent(Canvas.transform, false);
            Score.score += 500;
            dScoreA = 100f;
        }

        if (tScoreA == 35f)
        {
            GameObject Text = Instantiate(tAchievement, new Vector3(0f, 430f, 0f), Quaternion.identity);
            Text.transform.SetParent(Canvas.transform, false);
            Score.score += 500;
            tScoreA = 50f;
        }

        if (aScoreA == 4f)
        {
            GameObject Text = Instantiate(aAchievement, new Vector3(0f, 430f, 0f), Quaternion.identity);
            Text.transform.SetParent(Canvas.transform, false);
            Score.score += 500;
            aScoreA = 10f;
        }

        if (qScoreA == 12f)
        {
            GameObject Text = Instantiate(qAchievement, new Vector3(0f, 430f, 0f), Quaternion.identity);
            Text.transform.SetParent(Canvas.transform, false);
            Score.score += 500;
            qScoreA = 1000f;
        }

        if (qScoreA <= -1f)
        {
            qScoreA = 0f;
        }

    }

    public void destructableCombo()
    {
        destructablesScore += 1f;
        dScoreA += 1f;
    }

    public void torchCombo()
    {
        torchScore += 1f;
        tScoreA += 1f;
    }

    public void areaCombo()
    {
        areaScore += 1f;
        aScoreA += 1f;
    }

    public void questionPlusCombo()
    {
        questionScore += 1f;
        qScoreA += 1f;
    }

    public void questionMinusCombo()
    {
        questionScore -= 1f;
        qScoreA -= 1f;
    }

}
