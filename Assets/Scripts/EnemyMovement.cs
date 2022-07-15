using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    
    public float speed;
    public Transform[] waypoints;

    private Transform target;
    private int destPoint = 1;

    void Start()
    {
        target = waypoints[1];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            transform.Rotate(0.0f, 180f, 0.0f,Space.World);
            destPoint = (destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        player.transform.position = respawnPoint.transform.position;
    }
}
