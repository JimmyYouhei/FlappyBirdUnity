using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    // var that can make the object move
    public Vector2 velocity = Vector2.zero;

    Rigidbody2D body2d;


    private void Awake()
    {
        body2d = GetComponent<Rigidbody2D>();
    }


	// Update is called once per frame
	void FixedUpdate () {
        body2d.velocity = velocity;

        // if pause or die everything stop moving
        if (!BirdState.alive || PauseScript.isPaused)
        {
            body2d.velocity = Vector2.zero;
        }
	}
}
