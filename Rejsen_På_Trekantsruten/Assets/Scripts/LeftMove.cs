using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftMove : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    bool ispressed = false;
    public GameObject player;


    // Update is called once per frame
    void Update()
    {
        if (ispressed)
        {
            player.transform.Translate(-2.0f * Time.deltaTime, 0, 0);
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

    public void undoLeft()
    {
        if (ispressed)
        {
            Debug.Log("Left");
            player.transform.Translate(2.0f * Time.deltaTime, 0, 0);
        }
    }
}
