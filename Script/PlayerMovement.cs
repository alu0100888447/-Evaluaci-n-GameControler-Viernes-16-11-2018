using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 1000.0f;
    public float sidewaysForce = 50.0f;

    private void Start()
    {
        GameController.BallForceA += ForceA;
        GameController.BallForceD += ForceD;
        GameController.EndGame += EndGame;
    }


    // Update is called once per frame
    private void FixedUpdate () {

        rb.AddForce(forwardForce * Time.deltaTime, 0, 0);

        if (rb.position.y < -1f || forwardForce <= 0)
        {
            GameController.End();
        }
    }

    private void ForceA ()
    {
        rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
    }

    private void ForceD ()
    {
        rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
    }

    private void EndGame ()
    {
        gameObject.GetComponent<PlayerMovement>().enabled = false;
        FindObjectOfType<GameManager>().EndGame();
    }
}
