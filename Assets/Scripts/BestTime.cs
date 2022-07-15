using UnityEngine;
using UnityEngine.UI;

public class BestTime : MonoBehaviour
{
    public float time;

    public EndZone endZone;
    public Timer timer;

    [SerializeField] float bestTime;

    void Awake()
    {
        bestTime = PlayerPrefs.GetFloat("BestTime");
    }

    void Update()
    {
        GetComponent<Text> ().text = string.Format("Meilleur temps : {0:0}:{1:00}", Mathf.Floor(bestTime/60),bestTime%60);

        if(endZone.isInEndZone)
        {
            if (bestTime > timer.time || bestTime == 0)
            {
                bestTime = timer.time;
                PlayerPrefs.SetFloat("BestTime",bestTime);
            }
        }
        
    }

}
