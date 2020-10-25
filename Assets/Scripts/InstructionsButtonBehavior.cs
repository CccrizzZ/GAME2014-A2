using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/////////////////////////////////////////////////////////////
// Source File Name: InstructionsButtonBehavior.cs         //
// Student Name: Beining Liu                               //
// Student ID: 101193350                                   //
// Date Last Modified: Oct 24                              //
// Program Description: instruction button behavior script.//
/////////////////////////////////////////////////////////////

public class InstructionsButtonBehavior : MonoBehaviour
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

    public void OnInstructionButtonPressed()
    {
        StartCoroutine("InstructionRoutine");   
    }

    IEnumerator InstructionRoutine()
    {
        source.Play();
        yield return new WaitForSeconds(source.clip.length);
        Debug.Log("InstructionButton Pressed");
        SceneManager.LoadScene("GameInstructionScene");        
    }

}