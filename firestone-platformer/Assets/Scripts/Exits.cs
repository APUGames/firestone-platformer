using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exits : MonoBehaviour
{
    [SerializeField] float LevelLoadDelay = 1.0f;
    [SerializeField] float sloMoFactor = 0.2f;
   private void OnTriggerEnter2D (Collider2D collision)
    {
        StartCoroutine(LoadNextLevel()); 
    }

    IEnumerator LoadNextLevel()
    {
        Time.timeScale = sloMoFactor;

        yield return new WaitForSecondsRealtime(LevelLoadDelay);

        Time.timeScale = 1.0f;

        //add transitions or something here
        //like sounds or something

        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene (currentSceneIndex = 1);
    }
    
}
