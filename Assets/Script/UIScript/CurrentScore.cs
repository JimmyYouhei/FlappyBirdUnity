using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour {

	// on Start and On Enable to calculate score
	void Start () {
        GetComponent<Text>().text = BirdState.score.ToString();
	}

    private void OnEnable()
    {
        GetComponent<Text>().text = BirdState.score.ToString();
    }

}
