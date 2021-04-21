using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    string sceneName;
    UnityEngine.UI.Button btn;

    private void Start()
    {
        btn = this.GetComponent<UnityEngine.UI.Button>(); //knappen, som scriptet sidder på, lagres i en variabel
        btn.onClick.AddListener(ChangeScene); //når knappen trykkes, kaldes ChangeScene()-funktionen
        sceneName = SceneManager.GetActiveScene().name; //den aktive scenes navn lagres i en variabel
    }

    public void ChangeScene()
    {
        //det undersøges med if-sætninger, hvad det aktive scenenavn er, og hvilken scene, der så skal loades
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
