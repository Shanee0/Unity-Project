﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonControl : MonoBehaviour {
    public GameObject ball;
    public float thrust;
    bool placeOne;
    Rigidbody2D rb;
    public GameObject spawnLocation;
    




    // Use this for initialization
    void Start () {
        placeOne = false;
        rb = ball.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A))
        {
            RotateLeft();
        }


        if (Input.GetKey(KeyCode.D))
        {
            RotateRight();
        }

        //Get key down only presses it once so only spawns one.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            createBall();
            ball.GetComponent<Rigidbody2D>().velocity = new Vector2(200f, 0f);



        }
    }

    void RotateLeft()
    {
        transform.Rotate(Vector3.forward);
    }

    void RotateRight()
    {
        transform.Rotate(Vector3.back);
    }

    public void createBall()
    {
        Instantiate(ball, spawnLocation.transform.position, spawnLocation.transform.rotation);

    }




}
