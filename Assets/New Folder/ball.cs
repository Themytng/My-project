using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public float xSpeed = 0; //Horizontal speed (variable)
    public float ySpeed = 0; //vertical speed (variable)

    //Border variable
    private float xBorder = 7.5f; //variable for horizontal border
    private float yBorder = 4.5f; //variable for vertical border
  

    //variable for move state
    public bool xMove = true; //variable for horizontal state
    public bool yMove = true; //variable for vertical state

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
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y); //move left
        }

        if (transform.position.x >= xBorder) //Score for P2 & ricochet from border
        {
            xMove = false;
            playerOneScore++;
        }
        if (transform.position.x <= -xBorder) //score for P1
        {
            xMove = true;
            playerTwoScore++;
        }


        //vertical movement
        if (yMove == true)
        {
             transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed); //up movement
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - ySpeed); // down movement
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

    void OnCollisionEnter2D(Collision2D collision) //when a collision happens; makes the ball bounce from the paddles
    {
        Debug.Log("hit");
        if (collision.collider.CompareTag("Player"))
        {
            if (xMove == true)
            {
                xMove = false;
            }
            else if (xMove == false)
            {
                xMove = true;
            }
        }
    }

}
