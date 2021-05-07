using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPlayer : MonoBehaviour
{
    //string som fra start at s�rger for at der ikke er et baneskift igang
    private string baneSkift = "n";
    public GameObject obj;
    Vector3 startPos;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        // Start posistionen p� det objekt som scribtet ligger p� bliveer brugt som position  
        startPos = transform.position; 
        // Kompunentet rigidbody bruges til at fort�lle hvor hurtigt spilleren bev�ger sig 
        GetComponent<Rigidbody>().velocity = new Vector3(0,0, 2);
    }
    // Her styres venste knap
    public void Left()
    {
        // tjekker et baneskift allerede er igang og positionen af spilleren for at se om spilleren kan bev�ge sig til venstre
        if ((baneSkift == "n") && (transform.position.x > -.9))
        {
            // Rykker spilleren en til venstre p� banen
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 0, 2);
            // �ndre stringen baneskift til at v�re igang s� man ikke kan lave et banskift samtidig med at man er igang med det
            baneSkift = "y";
            StartCoroutine(StopLaneCh());
        }
    }
    // Her styres h�jre knap
    public void Right()
    {
        // tjekker et baneskift allerede er igang og positionen af spilleren for at se om spilleren kan bev�ge sig til h�jre
        if ((baneSkift == "n") && (transform.position.x < .9))
        {
            // Rykker spilleren en til h�jre p� banen
            GetComponent<Rigidbody>().velocity = new Vector3(1, 0, 2);
            // �ndre stringen baneskift til at v�re igang s� man ikke kan lave et banskift samtidig med at man er igang med det
            baneSkift = "y";
            StartCoroutine(StopLaneCh());
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, height, transform.position.z);
    }
    //  IEnumerator s�rger for at der skal v�re en pause p� 1 sekund mellem baneskiftene, men ikke mere hvis der bliver trykket mange gange i tr�k p� en knap
    IEnumerator StopLaneCh()
    {
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 2);
        baneSkift = "n";
    }
    // Funktionen tjekker om spilleren rammer en af forhindringerne. Hvis man g�r aktivere den funktionen EndGame i GameManagerShip scriptet
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            FindObjectOfType<GameManagerShip>().EndGame();
        }
    }
    
}
