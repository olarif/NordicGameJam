using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Tombstone : MonoBehaviour
{
    public Transform destination;
    public GameObject player;

    void OnTriggerEnter(Collider col){

        if(col.CompareTag("Player")){

            Debug.Log("Collided");
            FindObjectOfType<AudioManager>().Play("Ground Transfer 1"); 
            player.transform.Find("Player2D").gameObject.transform.position = destination.transform.position;
            player.GetComponent<SwitchPerspective>().GoDown();
        }
    }

}
