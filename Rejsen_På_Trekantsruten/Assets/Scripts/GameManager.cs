using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Jigsaw Variables
    public bool isJigsaw = false;
    public static int lockedPieces = 0;
    public static int usedMap = 0;
    public GameObject winScreen;
    public GameObject mapCounterText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(lockedPieces);
        if (lockedPieces == 36)
        {
            winScreen.SetActive(true);
            mapCounterText.GetComponent<Text>().text = "Du har brugt \"Vis Kort\" " + usedMap + " gange.";
        }
    }
}
