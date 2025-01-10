using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GradeManager gradeManager;
    public BehaviorManager behaviorManager;
    public ExtracurricularManager extracurricularManager;

    void Start()
    {
        Debug.Log("Welcome to Free School!");
    }

    public void EndDay()
    {
        Debug.Log("Day ended. Calculating performance...");
        gradeManager.UpdateGrade();
    }

    public void SkipClass()
    {
        Debug.Log("You skipped class!");
        behaviorManager.AddBadBehavior(5);
        gradeManager.SetClassParticipation(gradeManager.classParticipation - 10);
    }

    public void AttendClass()
    {
        Debug.Log("You attended class!");
        behaviorManager.AddGoodBehavior(5);
        gradeManager.SetClassParticipation(gradeManager.classParticipation + 10);
    }
}
