using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallScript : MonoBehaviour
{




    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 0f);



        Destroy(gameObject, 1.5f);



    }

    //static Quaternion LookAt2D(Vector2 forward)
   // {
        //return Quaternion.Euler(0, 0, Mathf.Atan2(forward.y, forward.x) * Mathf.Rad2Deg);



    //}

}

