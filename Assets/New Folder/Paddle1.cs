using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1 : MonoBehaviour
{
    //Variables for movement
    public float speed = 1f;
    public float yBorder = 6f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed);
        }
    }
}