using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float faster = 3f;
    public Vector3 spawnPoint;
    public int player1Score, player2Score;
    private Transform RespawnPoint;
    private bool player1W, player2W;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = transform.position;
        player1Score = 0;
        player2Score = 0;
        rb = gameObject.GetComponent<Rigidbody>();
        Debug.Log(player1Score + " - " + player2Score);
        rb.velocity = Vector3.left * 3f;
        player1W = false;
        player1W = false;
    }

    void Update()
    {
        if (player2Score == 11)
        {
            player2W = true;
            EndGame(player1W, player2W);
        }
        
        if (player1Score == 11)
        {
            player1W = true;
            EndGame(player1W, player2W);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player1")
        {
            rb.velocity = Vector3.right * 3f * faster;
            faster++;
        }

        if (collision.gameObject.tag == "Player2")
        {
            rb.velocity = Vector3.left * 3f * faster;
            faster++;
        }

        if (collision.gameObject.tag == "Top Wall")
        {
            //Vector3 downWards = new Vector3(0, -10, 0) *3f * faster;
            //rb.AddForce(downWards);
            rb.velocity = Vector3.down * 3f * faster;
        }

        if (collision.gameObject.tag == "Bot Wall")
        {
            rb.velocity = Vector3.up * 3f * faster; 
        }
        //rb = collision.gameObject.GetComponent<Rigidbody>();
        //rb.AddForce(Vector3.right);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal 1")
        {
            Debug.Log("Player2 has Scored!");
            player2Score++;
            Debug.Log(player1Score + " - " + player2Score);
            transform.position = spawnPoint;
            rb.velocity = Vector3.left * 3f;
            faster = 3f;

        }

        if (other.gameObject.tag == "Goal 2")
        {
            Debug.Log("Player1 has Scored!");
            player1Score++;
            
            Debug.Log(player1Score + " - " + player2Score);
            transform.position = spawnPoint;
            rb.velocity = Vector3.right * 3f;
            faster = 3f;
        }
    }

    public void EndGame(bool p1, bool p2)
    {
        if (p1)
        {
            Debug.Log("Player1 Wins");
            Debug.Log(player1Score + " - " + player2Score);
            Debug.Log("Tyrant Rave");
            rb.velocity = Vector3.right * 0f;
            Application.Quit();
        }

        else
        {
            Debug.Log("Player2 Wins");
            Debug.Log(player1Score + " - " + player2Score);
            Debug.Log("Ride the Fire");
            rb.velocity = Vector3.left * 0f;
            Application.Quit();
        }
    }
}
    