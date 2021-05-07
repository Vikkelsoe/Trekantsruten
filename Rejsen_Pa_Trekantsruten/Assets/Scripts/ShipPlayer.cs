using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPlayer : MonoBehaviour
{
    //string som fra start at sørger for at der ikke er et baneskift igang
    private string baneSkift = "n";
    public GameObject obj;
    Vector3 startPos;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        // Start posistionen på det objekt som scribtet ligger på bliveer brugt som position  
        startPos = transform.position; 
        // Kompunentet rigidbody bruges til at fortælle hvor hurtigt spilleren bevæger sig 
        GetComponent<Rigidbody>().velocity = new Vector3(0,0, 2);
    }
    // Her styres venste knap
    public void Left()
    {
        // tjekker et baneskift allerede er igang og positionen af spilleren for at se om spilleren kan bevæge sig til venstre
        if ((baneSkift == "n") && (transform.position.x > -.9))
        {
            // Rykker spilleren en til venstre på banen
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 0, 2);
            // ændre stringen baneskift til at være igang så man ikke kan lave et banskift samtidig med at man er igang med det
            baneSkift = "y";
            StartCoroutine(StopLaneCh());
        }
    }
    // Her styres højre knap
    public void Right()
    {
        // tjekker et baneskift allerede er igang og positionen af spilleren for at se om spilleren kan bevæge sig til højre
        if ((baneSkift == "n") && (transform.position.x < .9))
        {
            // Rykker spilleren en til højre på banen
            GetComponent<Rigidbody>().velocity = new Vector3(1, 0, 2);
            // ændre stringen baneskift til at være igang så man ikke kan lave et banskift samtidig med at man er igang med det
            baneSkift = "y";
            StartCoroutine(StopLaneCh());
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, height, transform.position.z);
    }
    //  IEnumerator sørger for at der skal være en pause på 1 sekund mellem baneskiftene, men ikke mere hvis der bliver trykket mange gange i træk på en knap
    IEnumerator StopLaneCh()
    {
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 2);
        baneSkift = "n";
    }
    // Funktionen tjekker om spilleren rammer en af forhindringerne. Hvis man gør aktivere den funktionen EndGame i GameManagerShip scriptet
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            FindObjectOfType<GameManagerShip>().EndGame();
        }
    }
    
}
