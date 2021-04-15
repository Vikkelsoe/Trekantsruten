using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public int nextScene;
    public bool additive;
    Button btn;

    // Start is called before the first frame update
    private void Start()
    {
        btn = this.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // TaskOnClick is called When the Button is clicked
    void TaskOnClick()
    {
        if (additive)
        {
            // Loader en scene oven i den eksisterende
            SceneManager.LoadScene(nextScene, LoadSceneMode.Additive);
        }
        else
        {
            // Loader kun en enkel scene
            SceneManager.LoadScene(nextScene);
        }
    }
}
