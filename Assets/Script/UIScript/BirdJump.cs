using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour {

    // jumpForce to store the force to jump (or to fly whatever)
    public float jumpForce;
    private Rigidbody2D bird2d;
    private bool jumpClicked;

    // Use this for initialization

    private void Awake()
    {
        bird2d = GetComponent<Rigidbody2D>();
    }

    void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        // when click on button and bird is alive
        if (jumpClicked && BirdState.alive)
        {
            jumpClicked = false;
            bird2d.velocity = new Vector2(bird2d.velocity.x, jumpForce);
            var birdState = GetComponent<BirdState>();
            birdState.audioSource.PlayOneShot(birdState.flyClip);
        }

        // below to make bird rotate
        if (bird2d.velocity.y > 0)
        {
            float angle = Mathf.Lerp(0, 90, bird2d.velocity.y / 7);
            transform.rotation = Quaternion.Euler(0, 0, angle);
        } else if (bird2d.velocity.y == 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        } else if (bird2d.velocity.y < 0)
        {
            float angle = Mathf.Lerp(0, -90,- bird2d.velocity.y / 7);
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }


	}

    // script for jump button
    public void JumpClicked()
    {
        jumpClicked = true;
    }

}
