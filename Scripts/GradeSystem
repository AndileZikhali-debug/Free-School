using UnityEngine;

public class GradeManager : MonoBehaviour
{
    public float examGrade = 0f; // Scale from 0 to 100
    public float classParticipation = 0f; // Scale from 0 to 100

    public void UpdateGrade()
    {
        float finalGrade = (examGrade + classParticipation) / 2;
        Debug.Log("Final Grade: " + finalGrade);

        if (finalGrade >= 50)
        {
            Debug.Log("Congratulations! You passed.");
        }
        else
        {
            Debug.Log("You failed. Better luck next time.");
        }
    }

    public void SetClassParticipation(float participation)
    {
        classParticipation = participation;
    }

    public void SetExamGrade(float grade)
    {
        examGrade = grade;
    }
}
