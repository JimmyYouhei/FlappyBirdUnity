using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScore : MonoBehaviour {

    // the Tect that show current score
    public Text scoreText;

    void Start()
    {
        // make it to 0 when start
        scoreText.text = "0";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // when bird go between pipe and check if bird still alive to avoid when bird die but due to velocity and still score
        if(collision.tag == "Pipe" && BirdState.alive)
        {
            // play ping sound
            GetComponent<BirdState>().audioSource.PlayOneShot(GetComponent<BirdState>().pingClip);
            // increase score by 1
            BirdState.score++;
            // make the score to Text in Text field
            scoreText.text = BirdState.score.ToString();
        }

    }

}
