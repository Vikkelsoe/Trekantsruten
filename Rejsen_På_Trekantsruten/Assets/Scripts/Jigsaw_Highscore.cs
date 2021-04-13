using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jigsaw_Highscore : MonoBehaviour
{
    public static float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void WriteHighscore()
    {
        PlayerPrefs.SetFloat("Highscore", time);

    }
}
