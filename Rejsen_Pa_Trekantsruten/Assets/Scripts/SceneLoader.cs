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
        sceneName = SceneManager.GetActiveScene().name; //den aktive scenes navn lagres i en variabel
        btn = this.GetComponent<UnityEngine.UI.Button>(); //knappen, som scriptet sidder på, lagres i en variabel
        btn.onClick.AddListener(ChangeScene); //når knappen trykkes, kaldes ChangeScene()-funktionen
    }

    public void ChangeScene()
    {
        //det undersøges med et switch-case statement, hvad det aktive scenenavn er, og hvilken scene, der så skal loades
        switch (sceneName)
        {
            case "Vejledning":
                SceneManager.LoadScene("Post1");
                break;
            case "HistorieP1.1":
                SceneManager.LoadScene("HistorieP1.2");
                break;
            case "HistorieP1.2":
                SceneManager.LoadScene("Vejledning_Puzzle");
                break;
            case "Vejledning_Puzzle":
                SceneManager.LoadScene("Puzzle");
                break;
            case "Puzzle":
                SceneManager.LoadScene("Post4");
                break;
            case "HistorieP4.1":
                SceneManager.LoadScene("HistorieP4.2");
                break;
            case "HistorieP4.2":
                SceneManager.LoadScene("Vejledning_Skib");
                break;
            case "Vejledning_Skib":
                SceneManager.LoadScene("Skib");
                break;
            case "Skib":
                SceneManager.LoadScene("Post6");
                break;
            case "HistorieP6":
                SceneManager.LoadScene("Vejledning_Labyrint");
                break;
            case "Vejledning_Labyrint":
                SceneManager.LoadScene("LabyrintSpil");
                break;
            case "LabyrintSpil":
                SceneManager.LoadScene("HistorieP7");
                break;
        }
        
        /*
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
        */
    }
}
