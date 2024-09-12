using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_TRAN : MonoBehaviour
{
    //Variables 

    public float speed = 3f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Find the position of the object every frame and make a vector
        Vector2 pos = transform.position;

        //If I press right arrow, move the postion to the right
        //If is called when input of right arrow is down
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;

        }

        //If I press A, move the position to the left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }

        //If I press up arrow, move the position up
        if(Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += speed * Time.deltaTime;
        }
        
        //If I press down arrow, move the position down
        if ((Input.GetKey(KeyCode.DownArrow)))
        {
            pos.y -= speed * Time.deltaTime;
        }

        //Transforms postion, needs to be the last line in update function
        transform.position = pos;
    }
}
