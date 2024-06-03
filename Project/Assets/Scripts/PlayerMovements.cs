using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovements : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    Rigidbody rb;

    float xInput;
    float zInput;

    float xForce;
    float zForce;

    public int score = 0;

    public int winScore;
    public GameObject winText;
    public GameObject scoreText;

    bool gameOver = false;
    public GameObject gameOverScreen;

    private void Awake()
    {
        // give access to the RigidBody component that we attached to the ball
        rb = GetComponent<Rigidbody>();
        gameOverScreen.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5f)
        {
            SceneManager.LoadScene("Game");
        }

        // Jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpHeight, ForceMode.Impulse);
        }
    }

    // fix - give a smooth move (fix time)
    private void FixedUpdate()
    {
        // Horizontal == left and right arrows
        // xInput - store info about L and R arrows keys
        xInput = Input.GetAxis("Horizontal");
        if (xInput != 0) {
            rb.AddForce(xInput * speed, 0, 0);
            xForce += xInput * speed;
        } else {
            rb.AddForce(-xForce, 0, 0);
            xForce = 0;
        }

        // Vertical == up and down arrows 
        zInput = Input.GetAxis("Vertical");
        if (zInput > 0) {  // allows only movement forward
            rb.AddForce(0, 0, zInput * speed);
            zForce += zInput * speed;
        } else {
            rb.AddForce(0, 0, -zForce);
            zForce = 0;
        }
    }


    // other - store info about object collider which the ball collide (here coin)

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            score++;
            scoreText.gameObject.SendMessage("SetScore", score);

            if (score >= winScore)
            {
                winText.SetActive(true);
            }
        } else if (other.gameObject.tag == "Puddle" || other.gameObject.tag == "Rock") {
            gameOver = true;
            gameOverScreen.SetActive(true);
        }
    }
}