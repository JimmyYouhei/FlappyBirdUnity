using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour {
    // store the fadeOut animation
    public GameObject fadeOut;

    public GameObject bird;
    
    // string scene name to load
    public string sceneName;

    public void ToScene()
    {
        // start the fade out animation and when complete loadNewscene
        Time.timeScale = 1;
        fadeOut.SetActive(true);
        // stop bird moving when fading out
        if(bird != null)
        {
            bird.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            bird.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
        StartCoroutine(SceneChange());
    }

    IEnumerator SceneChange()
    {
        yield return new WaitUntil(() => fadeOut.GetComponent<FadeOutComplete>().fadeOutComplete == true);
        SceneManager.LoadScene(sceneName);
    }
}
