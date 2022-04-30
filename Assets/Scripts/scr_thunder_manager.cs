using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_thunder_manager : MonoBehaviour
{
    public float maxThunder = 20f;
    public float minThunder = 10f;
    public float decreaseThunder = 2f;
    public float maxLightning = 10f;
    public float minLightning = 5f;
    public float decreaseLightning = 1f;

    float thunderTimer;
    float thunderReset;
    float lightningTriger;



    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Rain");
        thunderTimer = maxThunder;
        lightningTriger = maxLightning;
        thunderReset = maxThunder;

    }

    // Update is called once per frame
    void Update()
    {
       // decrease time remaining
       // if 0 trigger thunder
       // if low trigger warning
       // reset if 0 but lower to min 
        thunderTimer -= Time.deltaTime;
        //Debug.Log(thunderTimer);

        if (thunderTimer < lightningTriger)
        {
            Lightning();
        };

        if (thunderTimer < 0)
        {
            if (thunderReset > minThunder)
            {
                thunderReset -= decreaseThunder;
            }
            if (lightningTriger > minLightning)
            {
                lightningTriger -= decreaseLightning;
            }
            Thunder();
            thunderTimer = thunderReset;
        }
    }

    public void Thunder()
    {
        Debug.Log("Thunder");
        FindObjectOfType<AudioManager>().Play("Thunder");
    }

    public void Lightning()
    {
        Debug.Log("Lightning" + thunderTimer);
    }
}
