using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float xSpeed = 0; //Horizontal speed
    public float ySpeed = 0; //vertical speed

    //Border variable
    private float xBorder = 9f;
    private float yBorder = 4f;
    private float xNegBorder = -9f;
    private float yNegBorder = -4f;

    //variable for move state
    public bool xMove = true;
    public bool yMove = true;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.010f;
        ySpeed = 0.010f;

    }

    // Update is called once per frame
    void Update()
    {
        if (xMove)
        {
            transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y + ySpeed); //move right
        }
        else
        {
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y + ySpeed);
        }

        if (yMove)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed); //up
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - ySpeed);
        }



        if (transform.position.x >= xBorder) //in order, from top to bottom; left, right,down, and up movements.
        {
            xMove = false;
        }
        if (transform.position.x <= xNegBorder)
        {
            xMove = false;
        }
        if (transform.position.y >= yBorder)
        {
            ySpeed *= -1;
        }
        if (transform.position.y <= yNegBorder)
        {
            ySpeed *= -1;
        }
    }

    void OnCollisionEnter2D(Collision2D collision) //when a collision happens)
    {
        Debug.Log("hit");
        if (collision.collider.CompareTag("Player"))
        {
            if (xMove == true)
            {
                xMove = false;
            }
            else
            {
                xMove = true;
            }
        }
    }

}
