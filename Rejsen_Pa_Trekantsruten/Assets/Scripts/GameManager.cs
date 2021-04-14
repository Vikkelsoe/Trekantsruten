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
            float time = 0;
            time = timer;
            mapCounterText.GetComponent<Text>().text = "Du har brugt " + time + " sekunder.";
            Jigsaw_Highscore.time = timer;
        }
        if (lockedPieces != 36)
        {
            timer += Time.deltaTime;
        }
    }
}
