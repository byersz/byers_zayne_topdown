using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour
{
    public float speed = 7;
    public bool canMove = false;
    private bool movementDirection = false;
    private Rigidbody2D myRB;

    private Vector2 up;
    private Vector2 down;

    // Start is called before the first frame update
    void Start()
    {
        up = new Vector2(0, speed);
        down = new Vector2(0, -speed);

        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {

            if (movementDirection == false)
                myRB.velocity = down;

            else if (movementDirection == true)
                myRB.velocity = up;
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "trigger1")
        {
            movementDirection = false;
        }
        
        else if (collision.gameObject.name == "trigger2")
        {
            movementDirection = true;
        }
    }
}