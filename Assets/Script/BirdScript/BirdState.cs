using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdState : MonoBehaviour {

    // static so can easy access and a central place for calculation
    public static bool alive;
    public static int score;


    public  AudioSource audioSource;


    public  AudioClip flyClip, pingClip, dieClip;


    void Start () {
        // start setActive false to wait for instruction button
        gameObject.SetActive(false);
        // just to make sure
        alive = true;
        score = 0;
	}
	
}
