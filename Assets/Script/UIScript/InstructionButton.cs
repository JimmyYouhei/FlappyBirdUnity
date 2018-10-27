using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionButton : MonoBehaviour {

    public GameObject bird;
    public Button instructionButton;

    private void Start()
    {
        // at started pause everything 
        PauseScript.isPaused = true;
    }

    public void OnInstructionButtonClick()
    {
        // on click start play and bird
        bird.SetActive(true);
        instructionButton.gameObject.SetActive(false);
        PauseScript.isPaused = false;

        bird.GetComponent<Animator>().SetBool("Alive", true);
        bird.GetComponent<Animator>().SetInteger("BirdChoosen", PlayerPrefs.GetInt("BIRD"));

    }
}
