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

    private void Start()
    {
        PlayerPrefs.GetInt("tries");
    }

    public void EndGame() 
    {
        // Hvis spillet ikke allerede er stoppet, fordi man er død stoppes spillet og gameover skærmbilledet kommer frem  
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            gameOverUI.SetActive(true);
        }

        // Lægger 1 til antallet af forsøg brugt
        tries++;
    }

    // Hvis spillet er vundet kommer skærmbilledet op hvor man kan komme videre i spillet     
    public void CompleteLevel()
    {
        wonUI.SetActive(true);

        tries++;
        // Opdatere tidens highscore, hvis den blev slået
        if (tries < PlayerPrefs.GetInt("Ship_Highscore") || PlayerPrefs.GetInt("Ship_Highscore") <= 0)
        {
            PlayerPrefs.SetInt("Ship_Highscore", tries);
            Debug.Log(PlayerPrefs.GetInt("Ship_Highscore")+" Highscore");
        }
    }
    private void Update()
    {
        Debug.Log(tries);
    }

    public void Cheat()
    {
        GameObject.Find("ship").transform.position = new Vector3(-1, 0, 160);
        GameObject.Find("snyd").SetActive(false);
    }
}
