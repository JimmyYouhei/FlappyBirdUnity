using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour {

    // store pause state and mainPannel and gamoverText
    public static bool isPaused;
    public GameObject mainPanel;
    public Text gameOverText;


    public void PauseButtonClick()
    {
        if (!isPaused)
        {
            // set mainPannel except gameOver
            Time.timeScale = 0;
            isPaused = true;
            mainPanel.SetActive(true);
            gameOverText.gameObject.SetActive(false);

        }

    }
}
