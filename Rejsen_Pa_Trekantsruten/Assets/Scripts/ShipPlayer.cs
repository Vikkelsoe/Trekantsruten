using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPlayer : MonoBehaviour
{
    private string baneSkift = "n";
    public GameObject obj;
    Vector3 startPos;
    public float length;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        GetComponent<Rigidbody>().velocity = new Vector3(0,0, 2);
    }
    public void Left()
    {
        if ((baneSkift == "n") && (transform.position.x > -.9))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 0, 2);
            baneSkift = "y";
            StartCoroutine(stopLaneCh());
        }
    }
    public void Right()
    {
        if ((baneSkift == "n") && (transform.position.x < .9))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(1, 0, 2);
            baneSkift = "y";
            StartCoroutine(stopLaneCh());
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, height, transform.position.z);
    }
    IEnumerator stopLaneCh()
    {
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 2);
        baneSkift = "n";
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            FindObjectOfType<GameManagerShip>().EndGame();
        }
    }
}
