using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/////////////////////////////////////////////////
// Source File Name: DontDestroy.cs            //
// Student Name: Beining Liu                   //
// Student ID: 101193350                       //
// Date Last Modified: Oct 24                  //
// Program Description: don't destroy script.  //
/////////////////////////////////////////////////

public class DontDestroy : MonoBehaviour
{

    private void Awake() {

        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }


        DontDestroyOnLoad(this.gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "GPS")
        {
            Destroy(this.gameObject);
        }

    }
}
