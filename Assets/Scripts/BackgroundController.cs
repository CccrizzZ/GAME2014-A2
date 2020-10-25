using System.Collections;
using System.Collections.Generic;
using UnityEngine;


///////////////////////////////////////////////////////
// Source File Name: BackgroundController.cs         //
// Student Name: Beining Liu                         //
// Student ID: 101193350                             //
// Date Last Modified: Oct 24                        //
// Program Description: background controller script.//
///////////////////////////////////////////////////////


public class BackgroundController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;

    void Update()
    {
        Move();
        CheckBounds();
    }

    private void Reset()
    {
        transform.position = new Vector3(0.0f, verticalBoundary);
    }

    private void Move()
    {
        transform.position -= new Vector3(0.0f, verticalSpeed) * Time.deltaTime;
    }

    private void CheckBounds()
    {
        if (transform.position.y <= -verticalBoundary)
        {
            Reset();
        }
    }
}
