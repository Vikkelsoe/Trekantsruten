using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GameManagerShip : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject gameOverUI;
    public GameObject wonUI;
    Image progressBar;
    public float maxTime = 5f;
    float timeLeft;
    float timer = 0;

    private void Start()
    {
        progressBar = GetComponent<Image>();
        timeLeft = maxTime;
    }
    public void EndGame() 
    {
        // Hvis spillet ikke allerede er stoppet, fordi man er død stoppes spillet og gameover skærmbilledet kommer frem  
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            gameOverUI.SetActive(true);
        }
    }

    // Hvis spillet er vundet kommer skærmbilledet op hvor man kan komme videre i spillet     
    public void CompleteLevel()
    {
        wonUI.SetActive(true);
        Debug.Log(timer);
    }
    private void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            progressBar.fillAmount = timeLeft / maxTime;
        }

        timer += Time.deltaTime;
    }

    public void Cheat()
    {
        GameObject.Find("ship").transform.position = new Vector3(-1, 0, 160);
        GameObject.Find("snyd").SetActive(false);
    }
}
