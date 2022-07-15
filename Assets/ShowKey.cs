using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowKey : MonoBehaviour
{
    public AN_HeroInteractive AN_heroInteractive;

    public bool redKey;

    private void Awake() 
    {
        redKey = AN_heroInteractive.RedKey;
    }
    
    void Update()
    {
        if(redKey)
        {
            
        }
        /*else
        {
            gameObject.SetActive(true);
        }*/
    }
}
