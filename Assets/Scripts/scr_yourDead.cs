using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_yourDead : MonoBehaviour
{



    // Start is called before the first frame update
    void Awake()
    {

        Time.timeScale = 0.01f;
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
         if (Input.anyKey)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
