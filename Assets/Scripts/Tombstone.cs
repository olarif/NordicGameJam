using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Tombstone : MonoBehaviour
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

    void OnTriggerEnter(Collider col){

        if(col.CompareTag("Player")){
            FindObjectOfType<AudioManager>().Play("Ground Transfer 1"); 
            Debug.Log("Collided");
            //player.transform.Find("Player3D").gameObject.transform.position = new Vector3(0,0,0);
            //player.transform.Find("Player2D").gameObject.transform.position = new Vector3(0,0,0);
            player.transform.Find("Player2D").gameObject.transform.position = destination.transform.position;
            entryEvent.Invoke();
            
        }
    }
}
