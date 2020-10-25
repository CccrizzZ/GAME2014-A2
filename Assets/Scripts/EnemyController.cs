using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/////////////////////////////////////////////////
// Source File Name: EnemyController.cs        //
// Student Name: Beining Liu                   //
// Student ID: 101193350                       //
// Date Last Modified: Oct 24                  //
// Program Description: enemy movement script. //
/////////////////////////////////////////////////

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public float direction;

    // Update is called once per frame
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
        transform.position += new Vector3(0.0f, -0.05f);
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
}
