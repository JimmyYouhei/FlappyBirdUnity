using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseBird : MonoBehaviour {

    // store bird GameObject
    public GameObject bird;

    private void Start()
    {


        // reset birs choixe to default blue bird
        var birdAnimation = bird.GetComponent<Animator>();
        PlayerPrefs.SetInt("BIRD", 1);
        birdAnimation.SetInteger("BirdChoosen", PlayerPrefs.GetInt("BIRD"));
    }

    // when click will store PlayerPrefs the number of bird and change animation
    public void ChooseBirdClicked()
    {
        switch (PlayerPrefs.GetInt("BIRD"))
        {
            case 1:
                PlayerPrefs.SetInt("BIRD", 2);
                break;

            case 2:
                PlayerPrefs.SetInt("BIRD", 3);
                break;

            case 3:
                PlayerPrefs.SetInt("BIRD", 1);
                break;
        }

        var birdAnimation = bird.GetComponent<Animator>();
        birdAnimation.SetInteger("BirdChoosen", PlayerPrefs.GetInt("BIRD"));
    }

}
