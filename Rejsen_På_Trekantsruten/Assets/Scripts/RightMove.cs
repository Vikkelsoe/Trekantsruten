using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightMove : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    bool ispressed = false;
    public GameObject player;


    // Update is called once per frame
    void Update()
    {
        if (ispressed)
        {
            player.transform.Translate(1.5f * Time.deltaTime, 0, 0);
        }
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }

    public void undoRight()
    {
        if (ispressed)
        {
            Debug.Log("Right");
            player.transform.Translate(-2f * Time.deltaTime, 0, 0);
        }
    }

}