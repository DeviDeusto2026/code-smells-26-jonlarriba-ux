using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBehaviour : MonoBehaviour
{

    public Rigidbody playerRigidbody;

    private int groundCollisions;

    private int jumpForce = 400;

    private string groundLayer = "Ground";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer(groundLayer))
        {
            groundCollisions++;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer(groundLayer))
        {
            groundCollisions--;
        }
    }

    void Update()
    {
        bool isGrounded = groundCollisions > 0;

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jumpVector = new Vector3(0,1,0) * jumpForce;
            playerRigidbody.AddForce(jumpVector);
        }
    }

}