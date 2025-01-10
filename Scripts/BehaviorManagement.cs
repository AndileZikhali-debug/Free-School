using UnityEngine;

public class BehaviorManager : MonoBehaviour
{
    public int badBehaviorPoints = 0;
    public int goodBehaviorPoints = 0;

    public void AddBadBehavior(int points)
    {
        badBehaviorPoints += points;
        Debug.Log("Bad Behavior! Points: " + badBehaviorPoints);
        ApplyConsequences();
    }

    public void AddGoodBehavior(int points)
    {
        goodBehaviorPoints += points;
        Debug.Log("Good Behavior! Points: " + goodBehaviorPoints);
    }

    private void ApplyConsequences()
    {
        if (badBehaviorPoints >= 10)
        {
            Debug.Log("You've been sent to detention!");
        }
        else if (badBehaviorPoints >= 20)
        {
            Debug.Log("You've been suspended!");
        }
    }
}
