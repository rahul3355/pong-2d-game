using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries1 : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9.25f, 9.25f),Mathf.Clamp(transform.position.y, -4f , 4f), transform.position.z);
        
        
    }
}
