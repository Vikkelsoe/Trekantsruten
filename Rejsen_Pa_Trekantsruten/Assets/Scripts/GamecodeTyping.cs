using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamecodeTyping : MonoBehaviour
{
    public string theCode;
    public GameObject inputField;
    public GameObject textDisplay;



    public void StoreName()
    {
        theCode = inputField.GetComponent<Text>().text;

        if (theCode.ToLower() == "kshb")
        {
            SceneManager.LoadScene("HistorieP1.1");
        }
        else if (theCode.ToLower() == "idcy")
        {
            SceneManager.LoadScene("HistorieP4.1");
        }
        else if (theCode.ToLower() == "pimc")
        {
            SceneManager.LoadScene("HistorieP6");
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "Forkert kode";
        }

    }


    void Update()
    {

    }
}
