using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] playlist;
    public AudioClip victory;
    public AudioSource audioSource;
    private int musicIndex = 0;

    public EndZone endZone;

    void Start()
    {
        audioSource.clip = playlist[0];
        audioSource.Play();
    }

    void Update()
    {
        if(!audioSource.isPlaying && !endZone.isInEndZone)
        {
            PlayNextSong();
        }

        if(endZone.isInEndZone)
        {
            audioSource.clip = victory;
            //audioSource.Play();
        }
    }

    void PlayNextSong()
    {
        musicIndex = (musicIndex + 1) % playlist.Length;
        audioSource.clip = playlist[musicIndex];
        audioSource.Play();
    }
}
