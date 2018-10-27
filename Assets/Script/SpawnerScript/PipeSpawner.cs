using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    // use array to store what game object to spawn , delay time and the y min mac range
    public GameObject[] Pipes;
    public float delay;
    public float minRange = -1.5f;
    public float maxRange = 3f;

    // Use this for initialization
    void Start () {
        StartCoroutine(PipeSpawn());
    }

    // Update is called once per frame
    void Update () {
		
	}

    IEnumerator PipeSpawn()
    {
        // if not pause spawn object array use random
        if (!PauseScript.isPaused)
        {
            yield return new WaitForSeconds(delay);
            Vector3 positionToSpawn = new Vector3(transform.position.x, Random.Range(minRange, maxRange), transform.position.z);
            Instantiate(Pipes[Random.Range(0, Pipes.Length)], positionToSpawn, Quaternion.identity);
            StartCoroutine(PipeSpawn());
        }
        // if pause not spawn but run Coroutine so that this script run continously
        else if (PauseScript.isPaused)
        {
            yield return null;
            StartCoroutine(PipeSpawn());
        }

    }

}
