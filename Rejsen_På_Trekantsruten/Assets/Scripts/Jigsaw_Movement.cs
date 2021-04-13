using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jigsaw_Movement : MonoBehaviour
{
    public string pieceStatus = "idle";
    public bool checkPlacement = false;

    // Update is called once per frame
    void Update()
    {
        if (pieceStatus == "pickedUp")
        {
            // mousePosition gets the x and y coordinates of the mouse courser
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            // objectPosition translates the mousePosition into a position in the game
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            // Sets the position of this object to that of objPosition
            transform.position = objPosition;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if ((other.gameObject.name == gameObject.name) && (checkPlacement == true))
        {
            other.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            transform.position = other.gameObject.transform.position;
            pieceStatus = "locked";
        }
        if (pieceStatus == "locked" && checkPlacement == true)
        {
            checkPlacement = false;
            GameManager.lockedPieces++;
        }
    }

    private void OnMouseDown()
    {
        pieceStatus = "pickedUp";
        checkPlacement = false;
    }
    private void OnMouseUp()
    {
        pieceStatus = "idle";
        checkPlacement = true;
    }
}
