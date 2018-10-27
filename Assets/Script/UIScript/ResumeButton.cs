using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeButton : MonoBehaviour {

    // store mainPannel
    public GameObject mainPanel;

	public void ResumeClick()
    {
        // if bird still live
        if(BirdState.alive && PauseScript.isPaused)
        {
            Time.timeScale = 1;
            PauseScript.isPaused = false;
            mainPanel.SetActive(false);
        }

        // if bird die
        if (!BirdState.alive)
        {
            SceneManager.LoadScene("PlayScene");
        }

    }
}
