using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamecodeTyping : MonoBehaviour
{
    //en tekststreng-variabel og to variabler indeholdende spilobjekter deklareres
    public string theCode;
    public GameObject inputField;
    public GameObject textDisplay;


    //følgende funktion kaldes, når knappen på en kort-side trykkes
    public void CodeToScene()
    {
        theCode = inputField.GetComponent<Text>().text; //teksten, der står i input-feltet, gemmes i variablen

        //det undersøges med if-sætninger, om den indksrevne kode er korrekt, og i så fald loades den tilhørende scene
        //.ToLower() sætter alle de indskrevne bogstaver i lower-case
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
        else //hvis den indskrevne kode ikke er korrekt, skrives der "Forkert kode" på skærmen.
        {
            textDisplay.GetComponent<Text>().text = "Forkert kode";
        }
    }
}
