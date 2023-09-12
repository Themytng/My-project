using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1 : MonoBehaviour
{
    //Variables for movement
    public float speed = .001f;
    public float yBorder = 6f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y < yBorder) //when O is pressed
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed); //move up
        }

        if (Input.GetKey(KeyCode.S) && transform.position.y > -yBorder)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed);
        }
    }

    
}