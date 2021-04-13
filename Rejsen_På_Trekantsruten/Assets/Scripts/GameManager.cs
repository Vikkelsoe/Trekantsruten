using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Jigsaw Variables
    public bool isJigsaw = false;
    public static int lockedPieces = 0;
    public GameObject cam;


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
            cam.SetActive(false);
        }
    }
}
