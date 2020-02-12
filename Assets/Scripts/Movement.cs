using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 6f;
    public Vector3 move;
    private Vector3 scalerO, scalerN;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        scalerO = transform.localScale;
        scalerN = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z + 2);
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //print(Input.GetAxis("Vertical"));
        if (gameObject.tag == "Player1")
        {

            Vector3 move = new Vector3(0f, 0f, Input.GetAxis("Vertical"));
            rb.velocity = move * speed;
        }

        else if (gameObject.tag == "Player2")
        {
            Vector3 move = new Vector3(0f, 0f, Input.GetAxis("Horizontal"));
            rb.velocity = move * speed;
        }

        if ((Test.player1Score > 0 && Test.player2Score > 0) && Test.player1Score != Test.player2Score)
        {
            if (Test.player1Score % Test.player2Score == 0)
            {
                if (gameObject.tag == "Player2")
                {
                    transform.localScale = scalerN;
                }
            }

            else if (Test.player2Score % Test.player1Score == 0)
            {
                if (gameObject.tag == "Player1")
                {
                    transform.localScale = scalerN;
                }
            }
        }

        else
        {
            if (gameObject.tag == "Player2")
            {
                transform.localScale = scalerO;
            }

            if (gameObject.tag == "Player1")
            {
                transform.localScale = scalerO;
            }
        }

    }
}
    
    /*
    void FixedUpdate()
    {
        Moving(move);
    }

    void Moving(Vector3 things)
    {
        rb.velocity = move * speed;
    }
    */

