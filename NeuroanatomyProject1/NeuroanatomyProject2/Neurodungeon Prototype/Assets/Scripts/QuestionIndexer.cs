using UnityEngine;

public class QuestionIndexer : MonoBehaviour
{
    public questionManager qManager;

    private void Start()
    {
        qManager = GetComponentInParent<questionManager>();
    }

    public void Wrong1()
    {
        qManager.EnableWrongCanvas1();
    }
    
    public void Wrong2()
    {
        qManager.EnableWrongCanvas2();
    }
    
    public void Wrong3()
    {
        qManager.EnableWrongCanvas3();
    }
    
    public void Correct()
    {
        qManager.EnableCorrectCanvas();
    }
}
