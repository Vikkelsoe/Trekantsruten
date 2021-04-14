using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerShip : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject gameOverUI;
    public GameObject wonUI;


  

    public void EndGame() 
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            gameOverUI.SetActive(true);


          //Invoke("Restart", 2f);
          

        }
        

    }
    public void CompleteLevel()
    {
        Debug.Log("level won");
        wonUI.SetActive(true);

    }



}
