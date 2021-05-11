using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Jigsaw_GameManager : MonoBehaviour
{
    // Puslespilsvarialber
    public bool isJigsaw = false;
    public static int lockedPieces = 0;
    public static int usedMap = 0;
    GameObject winScreen;
    GameObject winText;

    // Finder spilobjektet med kortet, og definere det som "mapImage"
    public GameObject mapImage;

    // Spiltimeren
    float timer = 0;

    // Start bliver kaldt før første frame
    void Start()
    {
        // Tjekker om det er puslespillet der bliver spillet
        if (isJigsaw == true)
        {
            // Finder de spilobjekter der skal bruges i scenen
            winScreen = GameObject.Find("Win_Screen");
            winText = GameObject.Find("Time_Taken");

            // Deaktiverer vindeskærmen
            winScreen.SetActive(false);
        }
    }

    // Update bliver kaldt én gang per frame
    void Update()
    {
        // Tjekker om alle puslespilsbrikkerne er blevet lagt
        if (lockedPieces == 36)
        {
            // Aktiverer vindeskærmen
            winScreen.SetActive(true);
            // Opdatere texten på vindeskærmen med hvor lang tid der blev brugt, og hvor mange gange kortet blev brugt.
            winText.GetComponent<Text>().text = "Du har brugt " + Math.Round(timer, 1) + " sek. & \"Vis kort\" " + usedMap + " gange.";

            // Opdatere tidens highscore, hvis den blev slået
            if (timer < PlayerPrefs.GetFloat("Highscore_Time") || PlayerPrefs.GetFloat("Highscore_Time") < 0)
            {
                PlayerPrefs.SetFloat("Highscore_Time", timer);
            }
            // Opdatere kortets highscore, hvis den blev slået
            if (usedMap < PlayerPrefs.GetInt("Highscore_MapUse") || PlayerPrefs.GetInt("Highscore_MapUse") < 0)
            {
                PlayerPrefs.SetInt("Highscore_MapUse", usedMap);
            }

            // Gemmer highscoren
            PlayerPrefs.Save();
        }
        // Opdaterer tiden der er blevet brugt, hvis spillet ikke er slut
        if (lockedPieces < 36)
        {
            timer += Time.deltaTime;
        }
    }

    // DebugWin er brugt til at springe puslespillet over
    public void DebugWin()
    {
        lockedPieces = 36;
        GameObject.Find("Snyd").SetActive(false);
    }

    // ResetHighscore er brugt til at nulstile highscoren
    public void ResetHighscore()
    {
        lockedPieces++;
        PlayerPrefs.SetFloat("Highscore_Time", -1);
        PlayerPrefs.SetInt("Highscore_MapUse", -1);
    }

    // ShowMap bliver kaldt når knappen "Vis kort" bliver trykket
    public void ShowMap(bool display)
    {
        // Tjekker om kortet skal vises eller ej
        if (display == true)
        {
            // Aktivere kortet og lægger én til "usedMap"
            mapImage.SetActive(true);
            usedMap++;
        }
        else
        {
            // Deaktivere kortet
            mapImage.SetActive(false);
        }
    }
}