﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    [SerializeField]
    KeyCode MoveUp;
    [SerializeField]
    KeyCode MoveDown;


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

    // [SerializeField]
    // Vector2 v2Force;

    // [SerializeField]
    // KeyCode keyPositive;
    // [SerializeField]
    // KeyCode keyNegative;

    // void FixedUpdate()
    // {
    //     if (Input.GetKey(keyPositive))
    //         GetComponent<Rigidbody2D>().velocity += v2Force;

    //     if (Input.GetKey(keyNegative))
    //         GetComponent<Rigidbody2D>().velocity -= v2Force;
    // }

}
