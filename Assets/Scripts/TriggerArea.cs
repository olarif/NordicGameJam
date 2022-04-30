using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider col)
    {
        if(col.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("Scream1");   
            Debug.Log("Entered");
        }

    }

    void OnTriggerExit (Collider col)
    {
        if(col.CompareTag("Player"))
        {
            Debug.Log("Exited");
        }

    }
}
