using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_tutorial : MonoBehaviour
{

    public GameObject tutorial;
    // Update is called once per frame
    void Update()
    {
      if (Input.anyKey)
        {
             tutorial.SetActive(false);
        }  
    }
}
