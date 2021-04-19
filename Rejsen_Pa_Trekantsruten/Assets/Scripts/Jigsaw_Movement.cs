using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Jigsaw_Movement : MonoBehaviour
{
    // Puslespilsbrikkernes status
    public string pieceStatus = "idle";
    public bool checkPlacement = false;

    // Brikkernes lydkilde
    AudioSource audioPlaced;

    // Start bliver kaldt før første frame
    void Start()
    {
        // Brikkernes lydkilde bliver fundet
        audioPlaced = this.GetComponent<AudioSource>();
    }

    // Update bliver kaldt én gang per frame
    void Update()
    {
        // Tjekker om brikken er samlet op
        if (pieceStatus == "pickedUp")
        {
            // mousePosition finder x & y koordinatorne for musepillen
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            // objPosition oversætter mousePosition til en position i spillet
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            // Sætter positionen af dette objekt til det samme som objPosition
            transform.position = objPosition;
        }
    }

    // OnTriggerStay2D bliver kaldt når 2 collidere forbliver kollideret
    private void OnTriggerStay2D(Collider2D other)
    {
        // Tjekker om de to kolliderene objekter har det samme navn og om placeringen skal tjekkes
        if ((other.gameObject.name == gameObject.name) && (checkPlacement == true))
        {
            // Deaktivere boxcollideren på de to kolliderene objekter
            other.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            // Flytter puslespilsbrikken hen på sin låste position
            transform.position = other.gameObject.transform.position;
            // Opdatere brikkens status til "Låst"
            pieceStatus = "locked";
        }
        // Tjekker om brikken er låst, og om placeringen skal tjekkes
        if (pieceStatus == "locked" && checkPlacement == true)
        {
            // Slår placeringstjek fra
            checkPlacement = false;
            // Tilføjer én til låste brikker i Jigsaw_GameManager
            Jigsaw_GameManager.lockedPieces++;
            // Afspiller placeringslyden
            audioPlaced.Play();
        }
    }

    // OnMouseDown bliver kaldt når musseknappen trykkes ned
    private void OnMouseDown()
    {
        // Opdatere brikkens status til "Samlet op" og slår placeringstjek fra
        pieceStatus = "pickedUp";
        checkPlacement = false;
    }

    // OnMouseUp bliver kaldt når musseknappen løftes
    private void OnMouseUp()
    {
        // Opdatere brikkens status til "venter" og slår placeringstjek til
        pieceStatus = "idle";
        checkPlacement = true;
    }
}
