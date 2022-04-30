using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Tombstone : MonoBehaviour
{
    public Transform destination;
    public GameObject player;
    public GameObject PressE;

    void OnTriggerEnter(Collider col)
    {
        PressE.SetActive(true);
    }

        void OnTriggerExit(Collider col)
    {
        PressE.SetActive(false);
    }


    void OnTriggerStay(Collider col){

        if(col.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("Collided");
                PressE.SetActive(false);
                FindObjectOfType<AudioManager>().Play("Ground Transfer 1"); 
                FindObjectOfType<AudioManager>().Stop("Rain"); 
                player.transform.Find("Player2D").gameObject.transform.position = destination.transform.position;
                player.GetComponent<SwitchPerspective>().GoDown();
                StartCoroutine(cooldown());
            }

        }
    }

    private IEnumerator cooldown(){

        yield return new WaitForSeconds(1f);
    }

}
