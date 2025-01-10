using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameManager gameManager;

    public void OnAttendClassButton()
    {
        gameManager.AttendClass();
    }

    public void OnSkipClassButton()
    {
        gameManager.SkipClass();
    }

    public void OnEndDayButton()
    {
        gameManager.EndDay();
    }
}
