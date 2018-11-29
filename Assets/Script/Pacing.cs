using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacing : MonoBehaviour {
    public Vector3 PaceDirection = new Vector3(0, 0, 0);
    public float PaceDistance = 3.0f;
    public float movespeed = 3.0f;
    public float timer = 0.0f;
    Vector3 startPosition;
	// Use this for initialization
	void Start () {
        startPosition = transform.position;
        PaceDirection.Normalize();
        PaceDirection = PaceDirection * movespeed;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        Vector3 displacement = transform.position - startPosition;
        float distance = displacement.magnitude;
        if (distance >= PaceDistance && timer >= 0.5)
        {
            timer = 0;
            PaceDirection = -PaceDirection;
        }
        GetComponent<Rigidbody2D>().velocity = PaceDirection;
	}
}
