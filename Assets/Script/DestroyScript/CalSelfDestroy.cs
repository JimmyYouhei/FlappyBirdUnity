using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalSelfDestroy : MonoBehaviour {

    // some GameObject was created merely for calculate position so after start will make self-destruct
	void FixedUpdate () {
        Destroy(gameObject);
	}
}
