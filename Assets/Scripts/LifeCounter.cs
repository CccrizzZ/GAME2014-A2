using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/////////////////////////////////////////////////
// Source File Name: LifeCounter.cs            //
// Student Name: Beining Liu                   //
// Student ID: 101193350                       //
// Date Last Modified: Oct 24                  //
// Program Description: LifeCounter script.    //
/////////////////////////////////////////////////
public class LifeCounter : MonoBehaviour
{

    GameObject playerOBJ;
    Text life;
    PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
        life = GetComponent<Text>();
        playerOBJ = GameObject.Find("Player");
        pc = playerOBJ.GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        life.text = (pc.lifeCount).ToString();
    }
}
