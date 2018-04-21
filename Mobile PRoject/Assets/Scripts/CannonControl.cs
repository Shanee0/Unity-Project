using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonControl : MonoBehaviour {
    public GameObject ball;
    public float thrust;
    Rigidbody2D rb;
    public GameObject spawnLocation;
    




    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        // Rotate the cannon left
        if (Input.GetKey(KeyCode.A))
        {
            RotateLeft();
        }

        // Rotate the cannon right
        if (Input.GetKey(KeyCode.D))
        {
            RotateRight();
        }

        //Get key down only so it presses it once so only spawns one.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ball, spawnLocation.transform.position, spawnLocation.transform.rotation);
            
            ball.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(thrust, 0);



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
