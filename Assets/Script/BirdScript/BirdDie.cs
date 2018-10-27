using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdDie : MonoBehaviour {

    // object related when bird die
    public GameObject backgroundSpawner, pipeSpawnwer , mainPannel;

    // cheat field for testing
    [SerializeField]
    private bool cheat = false;

    // when bird collide and die
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // check if bird is alive to avoid recollise
        if (BirdState.alive && !cheat)
        {
            // set bird as dead
            BirdState.alive = false;
            // change bird animator to dead 
            GetComponent<Animator>().SetBool("Alive", BirdState.alive);
            // play the dead sound
            GetComponent<BirdState>().audioSource.PlayOneShot(GetComponent<BirdState>().dieClip);

            // deactive all spawner
            backgroundSpawner.SetActive(false);
            pipeSpawnwer.SetActive(false);

            // check to set high score
            if(PlayerPrefs.GetInt("HIGH")< BirdState.score)
            {
                PlayerPrefs.SetInt("HIGH", BirdState.score);
            }

            // acrive the Pannel
            mainPannel.SetActive(true);

        }

    }

}
