using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    string sceneName;
    Button btn;

    // Start is called before the first frame update
    private void Start()
    {
        btn = this.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        sceneName = SceneManager.GetActiveScene().name;
    }

    // TaskOnClick is called When the Button is clicked
    void TaskOnClick()
    {
        if (sceneName == "Vejledning")
        {
            SceneManager.LoadScene("HistorieP1.1");
        }
        else if (sceneName == "HistorieP1.1")
        {
            SceneManager.LoadScene("HistorieP1.2");
        }
        else if (sceneName == "HistorieP1.2")
        {
            SceneManager.LoadScene("HistorieP2");
        }
        else if (sceneName == "HistorieP2")
        {
            SceneManager.LoadScene("HistorieP3");
        }
        else if (sceneName == "HistorieP3")
        {
            SceneManager.LoadScene("HistorieP4.1");
        }
        else if (sceneName == "HistorieP4.1")
        {
            SceneManager.LoadScene("HistorieP4.2");
        }
        else if (sceneName == "HistorieP4.2")
        {
            SceneManager.LoadScene("HistorieP5");
        }
        else if (sceneName == "HistorieP5")
        {
            SceneManager.LoadScene("HistorieP6");
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
