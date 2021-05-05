using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public GameObject skibText;
    public GameObject puzzleText;
    public GameObject labText;

    void Start()
    {
        skibText.GetComponent<Text>().text = PlayerPrefs.GetInt("Ship_Highscore").ToString() + " forsøg";
        puzzleText.GetComponent<Text>().text = PlayerPrefs.GetFloat("Highscore_Time").ToString() + " sek.";
        labText.GetComponent<Text>().text = PlayerPrefs.GetFloat("Lab_Highscore").ToString() + " sek.";
    }
}
