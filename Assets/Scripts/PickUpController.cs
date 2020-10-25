using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/////////////////////////////////////////////////
// Source File Name: PickupController.cs       //
// Student Name: Beining Liu                   //
// Student ID: 101193350                       //
// Date Last Modified: Oct 24                  //
// Program Description: pickup movement script.//
/////////////////////////////////////////////////



public class PickUpController : MonoBehaviour
{

    public float horizontalSpeed;
    public float horizontalBoundary;
    public float direction;

    AudioSource auSource;

    // Start is called before the first frame update
    void Start()
    {
        auSource = GetComponent<AudioSource>();
    
    }

    void Update()
    {
        Move();
        CheckBounds();


        if(transform.position.y <= -6.0f)
        {
            
            Destroy(this.gameObject);

        }
    }



    private void Move()
    {
        transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, 0.0f, 0.0f);
        transform.position += new Vector3(0.0f, -0.001f);
    }
    


    private void CheckBounds()
    {
        // check right boundary
        if (transform.position.x >= horizontalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.x <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
    }


    private void OnCollisionEnter2D(Collision2D other) {
        // if(other.gameObject.name == "Player")
        // {
        //     auSource.Play();
        //     Destroy(this.gameObject, 0.1f);

        // }
    }

  

}
