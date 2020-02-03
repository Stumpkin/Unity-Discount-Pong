using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 6f;
    public Vector3 move;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
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
}
