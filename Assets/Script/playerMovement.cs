using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    public float jumpSpeed = 1.0f;
    bool grounded = false;
    public float moveSpeed = 1.0f;

	// Update is called once per frame
	void Update () {
        float moveX = Input.GetAxis("Horizontal");
        Vector3 Velocity = GetComponent<Rigidbody2D>().velocity;
        Velocity.x = moveX * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = Velocity;
        
        if(Input.GetButtonDown("Jump") && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,100 * jumpSpeed));
        }
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            grounded = true;
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            grounded = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            grounded = false;
        }
    }
}
