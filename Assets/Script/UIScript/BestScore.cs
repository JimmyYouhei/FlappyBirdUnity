using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour {

	//both start and on enable to make Text as current high scroe
	void Start () {
        GetComponent<Text>().text = PlayerPrefs.GetInt("HIGH").ToString();
	}

    private void OnEnable()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt("HIGH").ToString();
    }

}
