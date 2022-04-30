using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{

    void OnTriggerEnter (Collider col)
    {
        if(col.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("Scream1");   
            StartCoroutine(countdown());
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

    private IEnumerator countdown()
    {
        yield return new WaitForSeconds(3);
        FindObjectOfType<AudioManager>().Play("Scream2");
        this.transform.parent.gameObject.SetActive(false);

    }
}
