using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



///////////////////////////////////////////////////////////
// Source File Name: MainMenuButtonBehavior.cs           //
// Student Name: Beining Liu                             //
// Student ID: 101193350                                 //
// Date Last Modified: Oct 24                            //
// Program Description: main menu button behavior script.//
///////////////////////////////////////////////////////////

public class MainMenuButtonBehavior : MonoBehaviour
{

    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMainMenuButtonPressed()
    {
        StartCoroutine("MainMenuRoutine");
    }

    IEnumerator MainMenuRoutine()
    {

        source.Play();
        yield return new WaitForSeconds(source.clip.length);
        Debug.Log("MainMenu Pressed");
        SceneManager.LoadScene("GameMenuScene");
    }
}
