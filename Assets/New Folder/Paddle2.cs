using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour
{
    //Variables for movement
    public float speed = 0.001f;
    public float yBorder = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O) && transform.position.y < yBorder) //when O is pressed
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed); //move up
        }

        if (Input.GetKey(KeyCode.L) && transform.position.y > -yBorder)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed);
        }
    }


}