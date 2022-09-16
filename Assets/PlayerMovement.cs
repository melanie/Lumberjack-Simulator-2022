using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardsForce = 40f;
    public float sidewaysForce = 40f;
    public float decelerationMultiplier = 0.5f;
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer() {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, forwardsForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -forwardsForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else {
            rb.AddForce(-rb.velocity * decelerationMultiplier, ForceMode.Acceleration);
        }
    }
}
