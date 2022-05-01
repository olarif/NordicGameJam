using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    new public SpriteRenderer renderer;
    private UnityEngine.AI.NavMeshAgent agent;

    public Sprite frontSprite;
    public Sprite backSprite;

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

            renderer.sprite = backSprite;

            Vector3 dirToPlayer = transform.position - player.transform.position;

            Vector3 newPos = transform.position + dirToPlayer;

            agent.SetDestination(newPos);

        } else {

            renderer.sprite = frontSprite;
        }

    }
}
