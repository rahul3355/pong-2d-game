using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9.25f, 9.25f),Mathf.Clamp(transform.position.y, -2.70f , 2.70f), transform.position.z);
        
        
    }
}
