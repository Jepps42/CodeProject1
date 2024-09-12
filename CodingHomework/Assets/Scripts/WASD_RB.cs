using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class WASD_RB : MonoBehaviour
{
    //Variables
    public float forceamt = 5f;

    private int i = 8;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //Find the Rigidbody on the object this script is on
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //If statement to move right on screen by using D
        if (Input.GetKey(KeyCode.D))
        {
            //Make the rigidbody move right
            rb.AddForce(Vector2.right * forceamt);
            
        }

        //Make the rigidbody move left
        if (Input.GetKey(KeyCode.A)) 
        {
            rb.AddForce(Vector2.left * forceamt);
        }

        //Make the Rigidbody move up with W
        if (Input.GetKey(KeyCode.W)) 
        {
            rb.AddForce(Vector2.up * forceamt);
        }

        //Make the Rigidbody move down with S
        if(Input.GetKey(KeyCode.S)) 
        {
            rb.AddForce(Vector2.down * forceamt);
        }
    }
}
