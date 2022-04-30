using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPerspective : MonoBehaviour
{

    public Camera mainCam;

    public GameObject aboveGroundPlayer;
    public GameObject underGroundPlayer;

    // Start is called before the first frame update
    void Start()
    {
        aboveGroundPlayer.SetActive(true);
         FindObjectOfType<AudioManager>().Play("Rain");
        underGroundPlayer.SetActive(false);
    }

    public void GoDown()
    {
        Debug.Log("Going Down");
        mainCam.orthographic = true;
        //underGroundPlayer.transform.position = new Vector3(0,0,0);
        FindObjectOfType<AudioManager>().Play("Underground");
        FindObjectOfType<AudioManager>().Stop("Rain");
        aboveGroundPlayer.SetActive(false);
        underGroundPlayer.SetActive(true);

    }

    public void GoUp()
    {
        Debug.Log("Going Up");
        mainCam.orthographic = false;
        FindObjectOfType<AudioManager>().Play("Rain");
        FindObjectOfType<AudioManager>().Stop("Underground");
        aboveGroundPlayer.SetActive(true);
        underGroundPlayer.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.U)){
            GoUp();
        }
        else if (Input.GetKeyDown(KeyCode.I)){
            GoDown();
        }
    }
}
