using UnityEngine;

public class QuestionIndexer : MonoBehaviour
{
    public questionManager qManager;
    public QuestionRevisionManager revision;
    public int questnumb;

    private void Start()
    {
        qManager = GetComponentInParent<questionManager>();
    }

    public void Wrong1()
    {
        qManager.EnableWrongCanvas1();
        revision.Question(questnumb, false);
    }
    
    public void Wrong2()
    {
        qManager.EnableWrongCanvas2();
        revision.Question(questnumb, false);
    }
    
    public void Wrong3()
    {
        qManager.EnableWrongCanvas3();
        revision.Question(questnumb, false);
    }
    
    public void Correct()
    {
        qManager.EnableCorrectCanvas();
        revision.Question(questnumb, true);
    }
}
