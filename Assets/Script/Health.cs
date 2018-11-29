using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    float yVelocity;
    public GameObject PauseMenu;
    public Slider HealthSlider;
    public Slider HealthSlider2;
    public Text healthText;
    public int health = 10;
    float timer = 0.0f;
    public AudioClip soundToPlay;
    void Start()
    {
        Time.timeScale = 1;
        HealthSlider.GetComponent<Slider>().value = health;
        HealthSlider2.GetComponent<Slider>().value = health;
        healthText.GetComponent<Text>().text = "Health: " + health;
    }
    private void Update()
    {
        yVelocity = GetComponent<Rigidbody2D>().velocity.y;
        timer += Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && timer > 1.0 && yVelocity >= 0)
        {
            timer = 0;
            health -= 5;
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundToPlay);
            healthText.GetComponent<Text>().text = "Health: " + health;
            HealthSlider.GetComponent<Slider>().value = health;
            HealthSlider2.GetComponent<Slider>().value = health;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(20, 20));
        }
        if (collision.gameObject.tag == "Water")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
            if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    
}
