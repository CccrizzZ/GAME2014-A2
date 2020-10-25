using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

/////////////////////////////////////////////////
// Source File Name: PlayerController.cs       //
// Student Name: Beining Liu                   //
// Student ID: 101193350                       //
// Date Last Modified: Oct 24                  //
// Program Description: player movement script.//
/////////////////////////////////////////////////







public class PlayerController : MonoBehaviour
{

    public float lifeCount, ScoreCount;
    public float horizontalBoundary;

    public float horizontalSpeed;
    public float maxSpeed;
    public float horizontalTValue;

    public float fireDelay;

    // Private variables
    private Rigidbody2D m_rigidBody;
    private Vector3 m_touchesEnded;


    public GameObject Cam;

    // Start is called before the first frame update
    void Start()
    {
        Cam = GameObject.FindGameObjectWithTag("MainCamera");
        m_touchesEnded = new Vector3();
        m_rigidBody = GetComponent<Rigidbody2D>();
        lifeCount = 3;
        ScoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -5.0f)
        {
            Respawn();


        }
        


        Move();
        CheckBounds();

    }

    private void Respawn()
    {
        transform.position = new Vector3(0.0f, -3.5f);
        lifeCount -= 1;
        Cam.GetComponent<AudioSource>().Play();

        if (lifeCount < 0)
        {
            SceneManager.LoadScene("GameOverScene");

        }
    }


    private void Move()
    {
        float direction = 0.0f;

        // touch input support
        foreach (var touch in Input.touches)
        {
            var worldTouch = Camera.main.ScreenToWorldPoint(touch.position);

            if (worldTouch.x > transform.position.x)
            {
                direction = 1.0f;
            }

            if (worldTouch.x < transform.position.x)
            {
                direction = -1.0f;
            }

            m_touchesEnded = worldTouch;

        }

        // keyboard support
        if (Input.GetAxis("Horizontal") >= 0.1f) 
        {
            // direction is positive
            direction = 1.0f;
        }

        if (Input.GetAxis("Horizontal") <= -0.1f)
        {
            // direction is negative
            direction = -1.0f;
        }

        if (m_touchesEnded.x != 0.0f)
        {
           transform.position = new Vector2(Mathf.Lerp(transform.position.x, m_touchesEnded.x, horizontalTValue), transform.position.y);
        }
        else
        {
            Vector2 newVelocity = m_rigidBody.velocity + new Vector2(direction * horizontalSpeed, 0.0f);
            m_rigidBody.velocity = Vector2.ClampMagnitude(newVelocity, maxSpeed);
            m_rigidBody.velocity *= 0.99f;
        }
    }

    private void CheckBounds()
    {
        // check right bounds
        if (transform.position.x >= horizontalBoundary)
        {
            transform.position = new Vector3(horizontalBoundary, transform.position.y, 0.0f);
        }

        // check left bounds
        if (transform.position.x <= -horizontalBoundary)
        {
            transform.position = new Vector3(-horizontalBoundary, transform.position.y, 0.0f);
        }

    }

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(other.gameObject);
        Respawn();
    }
}
