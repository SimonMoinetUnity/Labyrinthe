using UnityEngine;

public class EndZone : MonoBehaviour
{
    [SerializeField] private GameObject endMessage;

    public bool isInEndZone = false;

    public AudioManager audioManager;
    
    private void OnTriggerEnter(Collider other) 
    {
        endMessage.SetActive(true);
        isInEndZone = true;
        audioManager.audioSource.clip = audioManager.victory;
        audioManager.audioSource.Play();
    }
}
