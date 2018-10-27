using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour {

    //store position and 2 background to spawn
    public GameObject backgroundSpawnerPos;
    public GameObject dayBackGround;
    public GameObject nightBackground;

    // bool to know what to spawn next
    private bool day = true;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // hit thrigger to spawn
        if(collision.tag == "Background")
        {
            Vector3 spawnPos = backgroundSpawnerPos.transform.position;
            if (day)
            {
                Instantiate(nightBackground, spawnPos, Quaternion.identity);
                day = false;
            } else if (!day)
            {
                Instantiate(dayBackGround, spawnPos, Quaternion.identity);
                day = true;
            }
        }

    }


}
