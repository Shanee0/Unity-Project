using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    // Create the varaibles, plubic health so we can change the health to test
    public int playerHealth;
    // Current health has to be static so its just for the class. So this currenthealth varabile is for all classes and not just an object.
    static int player1CurrentHealth;
    static int player2CurrentHealth;



    // Sets the current health to the playerhealth, need a current health to take away from.
    private void Awake()
    {
        player1CurrentHealth = playerHealth;
        player2CurrentHealth = playerHealth;

    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    

    
    
    // Method to get players health.
    public int getPlayer1Health()
    {
        return player1CurrentHealth;
    }

    public int getPlayer2Health()
    {
        return player2CurrentHealth;
    }

    //Take damage from player1 health
    public void Player1Damage(int dmg)
    {
        player1CurrentHealth = player1CurrentHealth - dmg;
        Debug.Log("Player 1 health is " + player1CurrentHealth);

    }
    //Take damage from player2 health
    public void Player2Damage(int dmg)
    {

        player2CurrentHealth = player2CurrentHealth - dmg;
        Debug.Log("Player 2 health is " + player2CurrentHealth);
    }
}
