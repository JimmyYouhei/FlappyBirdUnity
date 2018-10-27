using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPositionCalculate : MonoBehaviour {
    // store game object that is used to calculate the current gameobject position , use offset to offset as like
    public GameObject spawnPosCalculated;
    public float offsetX = 1.95f;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(spawnPosCalculated.transform.position.x  *  offsetX , spawnPosCalculated.transform.position.y, spawnPosCalculated.transform.position.z);
	}
	
}
