using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/////////////////////////////////////////////////
// Source File Name: ScoreCounter.cs           //
// Student Name: Beining Liu                   //
// Student ID: 101193350                       //
// Date Last Modified: Oct 24                  //
// Program Description: score counter script.  //
/////////////////////////////////////////////////

public class ScoreCounter : MonoBehaviour
{
    GameObject playerOBJ;
    Text score;
    PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        playerOBJ = GameObject.Find("Player");
        pc = playerOBJ.GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        score.text = (pc.ScoreCount).ToString();
    }
}
