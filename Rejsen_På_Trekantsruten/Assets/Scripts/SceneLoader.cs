using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int nextScene;
    public bool additive;

    // Update is called once per frame
    void Update()
    {
        if (additive)
        {
            // Loader en scene oven i den eksisterende
            SceneManager.LoadScene(nextScene, LoadSceneMode.Additive);
        }
        else
        {
            // Loader kun en enkel scene
            SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
        }
    }
}
