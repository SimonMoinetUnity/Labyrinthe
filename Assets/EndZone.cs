using UnityEngine;

public class EndZone : MonoBehaviour
{
    [SerializeField] private GameObject endMessage;

    public bool isInEndZone = false;
    
    private void OnTriggerEnter(Collider other) 
    {
        endMessage.SetActive(true);
        isInEndZone = true;
        
    }
}
