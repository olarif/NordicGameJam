using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_2d_Movement : MonoBehaviour
{
   //The speed the player moves at
   public float moveSpeed = 5f;

   //The Players rigid body
   public Rigidbody2D rb;

   /*
   //Sprint Speed
   public float sprintSpeed = 10f;
   //Stamina 
   public float maxStamina = 50f;
   float stamina = 0f;
   */

   //If the player is moving
   float movementX;
   float movementY;
   Vector2 direction;


    void Start()
    {
        //stamina = maxStamina;
    }

    // Update is called once per frame
    void Update()
    {
      //Grab input in vector 2 for movement
      movementX = Input.GetAxisRaw("Horizontal");     
      movementY = Input.GetAxisRaw("Vertical"); 

      
      Vector2 direction = new Vector2 (movementX, movementY).normalized;

      
      //Sprint System
     /* 
      if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
      {
        if (stamina > 0f) 
        {
            stamina = stamina - 1f * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + direction * sprintSpeed * Time.fixedDeltaTime);
        }
        else
        {
            rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
        }        
      }
      else
      {
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
        if (stamina < maxStamina)
        {
            stamina = stamina + 1f * Time.fixedDeltaTime;
        }
      }
    Debug.Log(stamina);
    */

    //Non sprint System
    rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
      

    }


    void OnTriggerStay2D(Collider2D col) 
    {
        if(col.CompareTag("ladder"))
        { 
          if (Input.GetKey(KeyCode.E))
          {
            Debug.Log("ladder triggered");
            //Triger Ladder !!!!!!!!!
          }
        }
    }
}