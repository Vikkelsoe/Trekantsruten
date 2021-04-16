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




        if (theCode == "PHP")
        {
            SceneManager.LoadScene("Prove1");
        }
        else if (theCode == "TTS")
        {
            SceneManager.LoadScene("Prove1");
        }
        else if (theCode == "LOL")
        {
            SceneManager.LoadScene("Prove1");
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
