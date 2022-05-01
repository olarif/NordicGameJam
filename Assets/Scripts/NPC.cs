using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;

    private GameObject player;

    public float EnemyDistanceRun = 4.0f;

    void Start()
    {
        player = GameObject.Find("Player3D");
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        
        if(distance < EnemyDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - player.transform.position;

            Vector3 newPos = transform.position + dirToPlayer;

            agent.SetDestination(newPos);

        }

    }
}
