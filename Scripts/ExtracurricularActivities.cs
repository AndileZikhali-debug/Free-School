using UnityEngine;

public class ExtracurricularManager : MonoBehaviour
{
    public enum Club { None, Sports, Music, Drama }
    public Club currentClub = Club.None;

    public void JoinClub(Club club)
    {
        currentClub = club;
        Debug.Log("Joined the " + club.ToString() + " club.");
    }

    public void LeaveClub()
    {
        Debug.Log("Left the " + currentClub.ToString() + " club.");
        currentClub = Club.None;
    }
}
