using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonControl : MonoBehaviour {
    public GameObject ball;
    public float thrust;
    private bool placeOne;
    Rigidbody2D rb;




    // Use this for initialization
    void Start () {
        placeOne = true;
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


        if(Input.GetKey(KeyCode.Space) && placeOne)
        {
            Rigidbody2D test;
           test =  Instantiate(ball.GetComponent<Rigidbody2D>(), transform.position,Quaternion.Euler(0,0,90)) as Rigidbody2D;
            test.AddForce(transform.forward * thrust);
            
            
            
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



}
