using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {

    // Obsolete not use anymore
	public void MenuClick()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
        if (PauseScript.isPaused)
        {
            PauseScript.isPaused = false;
        }
    }
}
