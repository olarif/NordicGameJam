using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Tombstone2D : MonoBehaviour
{

    public UnityEvent entryEvent;

    public Transform destination;
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){

        if(col.CompareTag("Player")){

            Debug.Log("Collided");
            //player.transform.Find("Player2D").gameObject.transform.position = new Vector3(0,0,0);
            //player.transform.Find("Player3D").gameObject.transform.position = new Vector3(0,0,0);
            player.transform.Find("Player3D").gameObject.transform.position = destination.transform.position;
            entryEvent.Invoke();
            
        }
    }
}
