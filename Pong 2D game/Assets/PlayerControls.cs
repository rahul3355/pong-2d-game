using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
public float speed;
//public float Yincrement;
private Rigidbody2D rb;
//private Vector2 targetPos;
private Vector2 moveVelocity;


    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        
    }

    void FixedUpdate() {

        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        
    }
}
