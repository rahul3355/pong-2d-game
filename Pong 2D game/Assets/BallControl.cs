using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num = Random.Range(1,11);
        if(num <= 5)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(80, 10));
        }
        else{
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-80, -10));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
