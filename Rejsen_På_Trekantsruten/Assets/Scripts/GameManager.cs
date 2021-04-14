using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
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
    public GameObject timeText;
    public GameObject timeHighscore;
    public GameObject mapHighscore;

    float timer = 0;

    

    /*public static async Task ExampleAsync()
    {
        string[] jigsawHigh =
        {
            "1", "2", "3"
        };
        File.AppendAllLines("Jigsaw_Highscores.txt", jigsawHigh);
    }*/

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
            timeText.GetComponent<Text>().text = "Du har brugt " + timer + " sekunder.";

            if (timer < PlayerPrefs.GetFloat("Highscore_Time") || PlayerPrefs.GetFloat("Highscore_Time") < 0)
            {
                PlayerPrefs.SetFloat("Highscore_Time", timer);
            }
            if (usedMap < PlayerPrefs.GetInt("Highscore_MapUse") || PlayerPrefs.GetInt("Highscore_MapUse") < 0)
            {
                PlayerPrefs.SetInt("Highscore_MapUse", usedMap);
            }

            timeHighscore.GetComponent<Text>().text = "Highscore \"Tid\" : " + PlayerPrefs.GetFloat("Highscore_Time");
            mapHighscore.GetComponent<Text>().text = "Highscore \"Kort Brugt\" : " + PlayerPrefs.GetInt("Highscore_MapUse");
            PlayerPrefs.Save();
        }
        if (lockedPieces < 36)
        {
            timer += Time.deltaTime;
        }
        Debug.Log(PlayerPrefs.GetFloat("Highscore_MapUse"));
    }
    public void DebugWin()
    {
        lockedPieces = 36;
    }

    public void ResetHighscore()
    {
        lockedPieces++;
        PlayerPrefs.SetFloat("Highscore_Time", -1);
        PlayerPrefs.SetInt("Highscore_MapUse", -1);
    }
}
