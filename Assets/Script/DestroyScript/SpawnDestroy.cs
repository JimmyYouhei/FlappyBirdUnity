using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDestroy : MonoBehaviour {

    // make Trigger collider so when background , pipe and zombie enter will destroy
    // Actually I enroll a course in unity and they taught to recycle for best performance this case. However I faild to understand so no copy and paste here 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Background" || collision.tag == "Pipe")
        {
            Destroy(collision.gameObject);
        }
    }
}
