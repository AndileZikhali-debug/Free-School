using UnityEngine;

public class NPC : MonoBehaviour
{
    public string npcName;

    public void Speak(string message)
    {
        Debug.Log(npcName + ": " + message);
    }
}
