using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimControlls : MonoBehaviour {

    public float X;
    public float Y;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        X = GetComponent<Rigidbody2D>().velocity.x;
        Y = GetComponent<Rigidbody2D>().velocity.y;
        
            GetComponent<Animator>().SetFloat("X", X);
            GetComponent<Animator>().SetFloat("Y", Y);
        
        
        if(X == 0 && Y == 0)
        {
            GetComponent<Animator>().SetBool("Idle", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Idle", false);
        }
        if(Input.GetButton("Fire1"))
        {
            GetComponent<Animator>().SetBool("Attack", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Attack", false);

        }
        /*if (X != 0)
            {
                GetComponent<Animator>().SetFloat("X", X);
                GetComponent<Animator>().SetBool("Idle", false);

            }
        else if(Y != 0)
            {
                GetComponent<Animator>().SetFloat("Y", Y);
                GetComponent<Animator>().SetBool("Idle", false);
            }
        else
            {
                GetComponent<Animator>().SetBool("Idle", true);
            }*/


    }
}
