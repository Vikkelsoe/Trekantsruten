using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameShip : MonoBehaviour
{
    public GameManagerShip gameManagerShip;

    void OnTriggerEnter()
    {
        gameManagerShip.CompleteLevel();

    }
}
