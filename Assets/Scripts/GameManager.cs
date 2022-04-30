using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{

    public GameObject AudioManager;

    public bool disableTestAudio = false;

    public CinemachineVirtualCamera upCam;
    public CinemachineVirtualCamera downCam;

    // Start is called before the first frame update
    void Start()
    {
        if(disableTestAudio){
            AudioManager.SetActive(false);
        }
        
        upCam.Priority = 10;
        downCam.Priority = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }

        if(Input.GetKeyDown(KeyCode.N)){
            upCam.Priority = 1;
            downCam.Priority = 10;
        }

        if(Input.GetKeyDown(KeyCode.M)){
            upCam.Priority = 10;
            downCam.Priority = 1;
        }
    }
}
