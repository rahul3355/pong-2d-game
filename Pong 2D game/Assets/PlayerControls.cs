using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed;

    public KeyCode moveUp;
    public KeyCode moveDown;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;

     void Start() 
    {
         //rb = GetComponent<Rigidbody2D>();
    }

     // Update is called once per frame
    void Update()
    {
        //Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //moveVelocity = moveInput.normalized * speed;

        if(Input.GetKeyDown(moveUp))
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 3 , 0);

        if(Input.GetKeyDown(moveDown))
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -3 , 0);

    }

    
    void FixedUpdate() {

       // rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        
   }

}
