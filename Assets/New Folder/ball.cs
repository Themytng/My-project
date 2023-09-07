using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float xSpeed = 0;
    public float ySpeed = 0;

    private float xBorder = 9f;
    private float yBorder = 5f;
    private float xNegBorder = -7.5f;
    private float yNegBorder = -5f;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.010f;
        ySpeed = 0.010f;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y + ySpeed);

        if (transform.position.x >= xBorder) //in order, from top to bottom; left, right,down, and up movements.
        {
            xSpeed = -xSpeed;
        }
        if (transform.position.x <= xNegBorder)
        {
            xSpeed = -xSpeed;
        }
        if (transform.position.y >= yBorder)
        {
            ySpeed = -ySpeed;
        }
        if (transform.position.y <= yNegBorder)
        {
            ySpeed = -ySpeed;
        }
    }
}
