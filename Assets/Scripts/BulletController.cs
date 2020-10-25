using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/////////////////////////////////////////////////
// Source File Name: BulletController.cs       //
// Student Name: Beining Liu                   //
// Student ID: 101193350                       //
// Date Last Modified: Oct 24                  //
// Program Description: bullet script.         //
/////////////////////////////////////////////////

public class BulletController : MonoBehaviour
{

    AudioSource auSource;



    GameObject playerOBJ;
    PlayerController pc;

    
    // Start is called before the first frame update
    void Start()
    {
        auSource = GetComponent<AudioSource>();
        playerOBJ = GameObject.Find("Player");
        pc = playerOBJ.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 5.17f)
        {
            Destroy(this.gameObject);
        }


        transform.position += new Vector3(0.0f, 0.1f);

    }



    private void OnCollisionEnter2D(Collision2D other) {
 
        auSource.Play();
        pc.ScoreCount += 100.0f;

        Destroy(this.gameObject, 0.1f);
        Destroy(other.gameObject);
    }

}
