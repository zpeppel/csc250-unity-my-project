using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript2 : MonoBehaviour
{
    Vector3 goForward, goBackwords, goLeft, goRight, goJump;
    public float speed = 2.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        goJump = new Vector3(0f, 1f, 0f);
        goForward = new Vector3(0f, 1f, 1f);
        goBackwords = new Vector3(0f, 1f, -1f);
        goLeft = new Vector3(-1f, 1f, 0f);
        goRight = new Vector3(1f, 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //this is the game object that this script is attached to

        if (Input.GetKeyDown("up"))
        {
            print("up key was pressed");
            
            rb.velocity = goForward * speed;
        }
        else if (Input.GetKeyDown("down"))
        {
            print("down key was pressed");
            
            rb.velocity = goBackwords * speed;
        }
        else if (Input.GetKeyDown("left"))
        {
            print("left key was pressed");
           
            rb.velocity = goLeft * speed;
        }
        else if (Input.GetKeyDown("right"))
        {
            print("right key was pressed");
            
            rb.velocity = goRight * speed;
        }
        else if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            rb.velocity = goJump * speed;
        }
    }
}
