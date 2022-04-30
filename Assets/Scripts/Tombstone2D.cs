using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Tombstone2D : MonoBehaviour
{

    public Transform destination;
    public GameObject player;
    public GameObject PressE;

    void OnTriggerEnter2D(Collider2D col)
    {
        PressE.SetActive(true);
    }

        void OnTriggerExit2D(Collider2D col)
    {
        PressE.SetActive(false);
    }


    void OnTriggerStay2D(Collider2D col){

        if(col.CompareTag("Player")){

            if(Input.GetKey(KeyCode.E)){
                PressE.SetActive(false);
                Debug.Log("Collided");
                FindObjectOfType<AudioManager>().Play("Ground Transfer 2"); 
                FindObjectOfType<AudioManager>().Play("Rain"); 
                player.transform.Find("Player3D").gameObject.transform.position = destination.transform.position;
                player.GetComponent<SwitchPerspective>().GoUp();
                StartCoroutine(cooldown());
            }

        }
    }

    private IEnumerator cooldown(){

        yield return new WaitForSeconds(1f);
    }
}
