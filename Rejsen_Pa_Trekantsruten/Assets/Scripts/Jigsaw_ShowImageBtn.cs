using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Jigsaw_ShowImageBtn : MonoBehaviour
{
    public GameObject mapImage;
    public void ShowMap(bool display)
    {
        if (display == true)
        {
            //Debug.Log("Pointer down");
            mapImage.SetActive(true);
            GameManager.usedMap++;
        }
        else
        {
            //Debug.Log("Poniter Up");
            mapImage.SetActive(false);
        }
    }
}
