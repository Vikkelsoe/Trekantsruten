using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jigsaw_Reset : MonoBehaviour
{
    Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn = this.GetComponent<Button>();
        //btn.onClick.AddListener(ResetHighscore);
    }

    void ResetHighscore()
    {
        PlayerPrefs.SetFloat("Highscore_Time", -1);
        PlayerPrefs.SetInt("Highscore_MapUse", -1);
    }
}
