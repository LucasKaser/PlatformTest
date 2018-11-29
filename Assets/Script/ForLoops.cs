using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour {
    int sum = 0;
	// Use this for initialization
	void Start () {
        for (int i = 1; i < 11; i++)
        { 
            Debug.Log("I am on itteration " + i);
        }
        for (int i = 176; i < 1001; i++)
        {
            sum += i;
        }
        Debug.Log(sum);
        for (int i = 1; i < 101; i++)
        {
            var die1 = Random.Range(1, 7);
            var die2 = Random.Range(1, 7);
            Debug.Log("you rolled a " + (die1 + die2));
            if(die1 + die2 == 12)
            {
                Debug.Log("You rolled a 12, critical hit");
                break;
            }
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
