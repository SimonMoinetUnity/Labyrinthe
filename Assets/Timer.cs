using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;

    public EndZone endZone;

    void Awake()
    {
        time = (int)Time.time;
    }

    void Update()
    {
        GetComponent<Text> ().text = string.Format("{0:0}:{1:00}",Mathf.Floor(time/60),time%60);

        if(!endZone.isInEndZone)
        {
            time = (int)Time.time;
        }
        
    }

}
