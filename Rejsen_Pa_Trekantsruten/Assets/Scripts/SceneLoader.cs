using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    string sceneName;
    UnityEngine.UI.Button btn;

    // Start is called before the first frame update
    private void Start()
    {
        btn = this.GetComponent<UnityEngine.UI.Button>();
        btn.onClick.AddListener(TaskOnClick);
        sceneName = SceneManager.GetActiveScene().name;
    }

    // TaskOnClick is called When the Button is clicked
    public void TaskOnClick()
    {
        if (sceneName == "Vejledning")
        {
            SceneManager.LoadScene("Post1");
        }
        else if (sceneName == "HistorieP1.1")
        {
            SceneManager.LoadScene("HistorieP1.2");
        }
        else if (sceneName == "HistorieP1.2")
        {
            SceneManager.LoadScene("Puzzle");
        }
        else if (sceneName == "Puzzle")
        {
            SceneManager.LoadScene("Post4");
        }
        else if (sceneName == "HistorieP4.1")
        {
            SceneManager.LoadScene("HistorieP4.2");
        }
        else if (sceneName == "HistorieP4.2")
        {
            SceneManager.LoadScene("Skib");
        }
        else if (sceneName == "Skib")
        {
            SceneManager.LoadScene("Post6");
        }
        else if (sceneName == "HistorieP6")
        {
            SceneManager.LoadScene("LabyrintSpil");
        }
        else if (sceneName == "LabyrintSpil")
        {
            SceneManager.LoadScene("HistorieP7");
        }
    }
}
