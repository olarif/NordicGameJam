using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPerspective : MonoBehaviour
{
    public float maxThunder = 20f;
    public float minThunder = 10f;
    public float decreaseThunder = 2f;
    public float maxLightning = 10f;
    public float minLightning = 5f;
    public float decreaseLightning = 1f;
    public GameObject lightningEffect;

    float thunderTimer;
    float thunderReset;
    float lightningTriger;
    float lightningTimerReset = 0.5f;
    float lightningTimer = 0.5f;
    bool lightningFlip = true;
    bool onSwitch = true;
    bool aboveGround = true;

    public Camera mainCam;

    public GameObject aboveGroundPlayer;
    public GameObject underGroundPlayer;


    // Start is called before the first frame update
    void Start()
    {
        aboveGroundPlayer.SetActive(true);
         FindObjectOfType<AudioManager>().Play("Rain");
        underGroundPlayer.SetActive(false);

        thunderTimer = maxThunder;
        lightningTriger = maxLightning;
        thunderReset = maxThunder;

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

        aboveGround = false;

    }

    public void GoUp()
    {
        Debug.Log("Going Up");
        mainCam.orthographic = false;
        FindObjectOfType<AudioManager>().Play("Rain");
        FindObjectOfType<AudioManager>().Stop("Underground");
        aboveGroundPlayer.SetActive(true);
        underGroundPlayer.SetActive(false);

        aboveGround = true;

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.U)){
            GoUp();
        }
        else if (Input.GetKeyDown(KeyCode.I)){
            GoDown();
        }
        */

           // decrease time remaining
        // if 0 trigger thunder
        // if low trigger warning
        // if 0 trigger thunder
        // play sound
        // kill player if above ground
        // if bellow ground shut off
        // while shut off if above ground restart
        
        if (onSwitch == true)
        {
            thunderTimer -= Time.deltaTime;
            Debug.Log(thunderTimer);

            if (thunderTimer < lightningTriger)
            {
                Lightning();
            };

            if (thunderTimer < 0f)
            {           
                Thunder();
                onSwitch = false;
            }
        }

        if (onSwitch == false && aboveGround == true)
        {
            ResetTimer();
        }


    }

    public void Thunder()
    {
        Debug.Log("Thunder");
        FindObjectOfType<AudioManager>().Play("Thunder");
        if (aboveGround == true) 
        {
            Debug.Log("Your Dead");
        }
        lightningEffect.SetActive(false);
    }

    public void Lightning()
    {
        Debug.Log("Lightning" + thunderTimer);
        //activate lightning
        //decrease timer
        //deactivate timer 
        if (lightningFlip == true)
        {
            if (lightningTimer > 0f)
            {
                lightningEffect.SetActive(true);
                lightningTimer -= Time.deltaTime;
            }
            else if (lightningTimer < 0f)
            {
                lightningTimer = lightningTimerReset;
                lightningFlip = false;
            }
        }
        else
        {
            if (lightningTimer > 0f)
            {
                lightningEffect.SetActive(false);
                lightningTimer -= Time.deltaTime;
            }
            else if (lightningTimer < 0f)
            {
                lightningTimer = lightningTimerReset;
                lightningFlip = true;
            }
        }


    }

    public void ResetTimer ()
    {
        if (thunderReset > minThunder)
        {
            thunderReset -= decreaseThunder;
        }
        if (lightningTriger > minLightning)
        {
            lightningTriger -= decreaseLightning;
        }
        thunderTimer = thunderReset;
        onSwitch = true;
    }
}
