using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public string npcName;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            npcName = other.gameObject.name;
            Debug.Log("Interacting with " + npcName);
            // Add specific interaction logic here
        }
    }
}
