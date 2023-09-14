using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public float xSpeed = 0; //Horizontal speed
    public float ySpeed = 0; //vertical speed

    //Border variable
    private float xBorder = 7.5f;
    private float yBorder = 4.5f;
  

    //variable for move state
    public bool xMove = true;
    public bool yMove = true;

    //score variables
    int playerOneScore;
    int playerTwoScore;
    public Text scoreTextP2;
    public Text scoreTextP1;
  

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.0125f;
        ySpeed = 0.0125f;

    }

    // Update is called once per frame
    void Update()
    {
        if (xMove == true)
        {
            transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y); //move right
        }
        else
        {
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y); // left
        }

        if (transform.position.x >= xBorder) 
        {
            xMove = false;
            playerOneScore++;
        }
        if (transform.position.x <= -xBorder)
        {
            xMove = true;
            playerTwoScore++;
        }


        //vertical movement
        if (yMove == true)
        {
             transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed); //up
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - ySpeed); // down
        }

    
        if (transform.position.y >= yBorder)
        {
            yMove = false;
        }
        if (transform.position.y <= -yBorder)
        {
            yMove = true;
        }

        scoreTextP1.text = playerOneScore.ToString();
        scoreTextP2.text = playerTwoScore.ToString();
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
