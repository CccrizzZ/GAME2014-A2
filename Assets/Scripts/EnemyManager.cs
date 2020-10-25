using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/////////////////////////////////////////////////
// Source File Name: EnemyManager.cs           //
// Student Name: Beining Liu                   //
// Student ID: 101193350                       //
// Date Last Modified: Oct 24                  //
// Program Description: enemy manager script.  //
/////////////////////////////////////////////////


[System.Serializable]
public class EnemyManager : MonoBehaviour
{

    public GameObject rat;
    
    void Start()
    {

    }



    void Update()
    {
        Vector3 SpawnPosition = new Vector3(Random.Range(-2.5f, 2.5f), 10.5f);

        if(Time.frameCount % 120 == 0)
        {
            rat.transform.position = SpawnPosition;
            Instantiate(rat);
        }
    }



}
