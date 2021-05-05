using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerShip : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject gameOverUI;
    public GameObject wonUI;
    int tries = 0;

    public void EndGame() 
    {
        // Hvis spillet ikke allerede er stoppet, fordi man er d�d stoppes spillet og gameover sk�rmbilledet kommer frem  
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            gameOverUI.SetActive(true);
        }

        // L�gger 1 til antallet af fors�g brugt
        tries++;
    }

    // Hvis spillet er vundet kommer sk�rmbilledet op hvor man kan komme videre i spillet     
    public void CompleteLevel()
    {
        wonUI.SetActive(true);
    }

    private void Update()
    {
        // Opdatere tidens highscore, hvis den blev sl�et
        if (tries < PlayerPrefs.GetInt("Ship_Highscore") || PlayerPrefs.GetInt("Ship_Highscore") <= 0)
        {
            PlayerPrefs.SetInt("Ship_Highscore", tries);
        }

    }

}
