using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Tombstone2D : MonoBehaviour
{

    public Transform destination;
    public GameObject player;

    void OnTriggerEnter2D(Collider2D col){

        if(col.CompareTag("Player")){

            Debug.Log("Collided");
            FindObjectOfType<AudioManager>().Play("Ground Transfer 2"); 
            FindObjectOfType<AudioManager>().Play("Rain"); 
            player.transform.Find("Player3D").gameObject.transform.position = destination.transform.position;
            player.GetComponent<SwitchPerspective>().GoUp();
            
        }
    }

}
