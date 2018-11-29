using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStomp : MonoBehaviour {
    public GameObject prefab;
    void OnCollisionEnter2D(Collision2D collision)
    {
        float yVelocity = GetComponent<Rigidbody2D>().velocity.y;
        if (collision.gameObject.tag == "Player" && yVelocity <= 0)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 40));
            Destroy(gameObject);
            // Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}
