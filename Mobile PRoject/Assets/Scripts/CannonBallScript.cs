using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallScript : MonoBehaviour
{
    // if script is on another Object in unity we need to create a new GameObject as well as the script
    public GameObject player2;

    // This sets the damage this prefab gives
    public int damage = 10;

    // This references the script the Game object has
    private PlayerControl playerControl;


    // Use this for initialization
    void Start()
    {
        // Create the reference to the object the script is on As player2 is set in the inspector in unity this then grabs the script it has by naming it.
        playerControl = player2.GetComponent<PlayerControl>();

    }

    // Update is called once per frame
    void Update()
    {
        // Moves the ball along the x axies by 10f. **We will need to update this to include a parabola affect so it dips. Will need to look into Maths**.
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 0f);


        // Destroys the clones in 1.5 seconds. **Will need to create an object pool so it reuses the same objects. Set it to false and then set it to true when being used**.
        Destroy(gameObject, 1.5f);

        
    }

    // Method to return the damage. Use this to get the damage value to pass into other scripts as below.
    public int GetDamage()
    {
        return damage;
    }



    // When this object collides with another on exit, send a message to the player control script to take of the damage from the health. 
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player1")
        {
            // Send the message to player control to take of some health. Use the method above to get the value.
            playerControl.Player1Damage(GetDamage());
            
        } else if (collision.gameObject.tag == "Player2")
        {
            playerControl.Player2Damage(GetDamage());
        }

        Destroy(gameObject);


    }

    



}

