using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public AudioSource scream;
    public AudioSource scream2;
    public bool triggered = false;

    void OnTriggerEnter (Collider col)
    {
        if(col.CompareTag("Player"))
        {
            if(!triggered){
                scream.Play();
                //FindObjectOfType<AudioManager>().Play("Scream1");   
                StartCoroutine(countdown());
                triggered = true;
                //Debug.Log("Entered");
            }
        }

    }

    void OnTriggerExit (Collider col)
    {
        if(col.CompareTag("Player"))
        {
            StartCoroutine(wait(2));
            triggered = false;
        }

    }

    private IEnumerator wait(float seconds){
        yield return new WaitForSeconds(seconds);
    }

    private IEnumerator countdown()
    {
        yield return new WaitForSeconds(3);
        scream2.Play();
        yield return new WaitForSeconds(.2f);
        ScoreManager.instance.AddPoint(25);
        this.transform.parent.gameObject.SetActive(false);

    }
}
