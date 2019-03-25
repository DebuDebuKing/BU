using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    //   public float speed = 5f;
    //   Rigidbody2D rb;

    //   Vector2 moveVelocity;
    //   // Use this for initialization
    //   void Start () {
    //       rb = GetComponent<Rigidbody2D>();
    //}

    //// Update is called once per frame
    //void Update () {

    //       Vector2 move_input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    //       moveVelocity = move_input.normalized * speed;

    //}


    //   void FixedUpdate ()
    //   {
    //       rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    //   }


    Rigidbody2D rb;
    public float speed = 10f;
    public float movementup;
    float movementside;
   
   

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
       
    }

    private void Update()
    {
        //anim.setbool("walk" , true);

        movementside = Input.GetAxisRaw("Horizontal");
        movementup = Input.GetAxisRaw("Vertical");
        if(movementup == 1)
        {
            rb.velocity = new Vector2(rb.velocity.x, movementup * speed);
            
        }
         if (movementup < 1)
        {
            rb.velocity = new Vector2(rb.velocity.x, movementup * speed);
            
        }

         if(movementside == 1)
        {
            rb.velocity = new Vector2(movementside * speed, rb.velocity.y);
            
        }
        if (movementside < 1)
        {
            rb.velocity = new Vector2(movementside * speed, rb.velocity.y);
            
        }

        

    }

}
