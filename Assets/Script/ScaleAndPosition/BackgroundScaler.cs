using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScaler : MonoBehaviour {

    // size of the background
    public Vector2 backGroundSize = new Vector2(720, 1280);


	// Use this for initialization
	void Awake () {

        // the aspect ratio of background
        float standardAspectRatio = backGroundSize.x / backGroundSize.y;
        // aspect ratio of screen
        float currentScreenAspectRatio = (float)Screen.width / (float)Screen.height;

        // calculate the scale to scale use Ceil so go a bit over just to make sure
        float scale = Mathf.Ceil(currentScreenAspectRatio / standardAspectRatio * transform.localScale.x);

        transform.localScale = new Vector3( scale , transform.localScale.y, transform.localScale.z);

	}
	
}
