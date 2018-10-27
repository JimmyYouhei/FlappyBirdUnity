using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedalScript : MonoBehaviour {

    // store the medal sprite 
    [SerializeField]
    private Sprite whiteMedal, bronzeMedal, goldMedal;

    // use both start and OnEnable to calculate what medal
    private void Start()
    {
        
        var image = GetComponent<Image>();

        // Calculate when pause
        if (BirdState.alive && PauseScript.isPaused)
        {
            if (PlayerPrefs.GetInt("HIGH") <= 20)
            {
                image.sprite = whiteMedal;
            }
            else if (PlayerPrefs.GetInt("HIGH") > 20 && PlayerPrefs.GetInt("HIGH") < 40)
            {
                image.sprite = bronzeMedal;
            }
            else if (PlayerPrefs.GetInt("HIGH") >= 40)
            {
                image.sprite = goldMedal;
            }
        }
        // calculate when bird die 
        else if (!BirdState.alive)
        {
            if (BirdState.score <= 20)
            {
                image.sprite = whiteMedal;
            }
            else if (BirdState.score> 20 && BirdState.score < 40)
            {
                image.sprite = bronzeMedal;
            }
            else if (BirdState.score >= 40)
            {
                image.sprite = goldMedal;
            }
        }

    }

    private void OnEnable()
    {
        var image = GetComponent<Image>();
        if (BirdState.alive && PauseScript.isPaused)
        {
            if (PlayerPrefs.GetInt("HIGH") <= 20)
            {
                image.sprite = whiteMedal;
            }
            else if (PlayerPrefs.GetInt("HIGH") > 20 && PlayerPrefs.GetInt("HIGH") < 40)
            {
                image.sprite = bronzeMedal;
            }
            else if (PlayerPrefs.GetInt("HIGH") >= 40)
            {
                image.sprite = goldMedal;
            }
        }
        else if (!BirdState.alive)
        {
            if (BirdState.score <= 20)
            {
                image.sprite = whiteMedal;
            }
            else if (BirdState.score > 20 && BirdState.score < 40)
            {
                image.sprite = bronzeMedal;
            }
            else if (BirdState.score >= 40)
            {
                image.sprite = goldMedal;
            }
        }

    }

}
