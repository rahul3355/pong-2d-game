using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    Camera mainCam;
    BoxCollider2D topWall;
    BoxCollider2D bottomWall;
    BoxCollider2D leftWall;
    BoxCollider2D rightWall;

    Transform Player01;
    Transform Player02;

    // Update is called once per frame
    void Update()
    {
        //move each wall to it's edge location
        topWall.size = new Vector2( mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        topWall.offset = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);


        
    }
}
