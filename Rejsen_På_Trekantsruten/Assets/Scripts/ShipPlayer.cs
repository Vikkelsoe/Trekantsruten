using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPlayer : MonoBehaviour
{
    private string baneSkift = "n";


    public GameObject obj;
    //Vector3 camPos;
    Vector3 startPos;
    //float speed = 3;

    public float length;
    public float height;
    
    

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        //offset = obj.transform.position;
        GetComponent<Rigidbody>().velocity = new Vector3(0,0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = camPos + offset;   

        //transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, length)+height, transform.position.z);
        transform.position = new Vector3(transform.position.x, height, transform.position.z);

        if ((Input.GetKey("a"))&&(baneSkift=="n")&&(transform.position.x>-.9))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 0, 2);
            baneSkift = "y";
            StartCoroutine(stopLaneCh());

        }
        if ((Input.GetKey("d"))&&(baneSkift=="n") && (transform.position.x < .9))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(1, 0, 2);
            baneSkift = "y";
            StartCoroutine(stopLaneCh());

        }

    }
    IEnumerator stopLaneCh()
    {
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 2);
        baneSkift = "n";
        //Debug.Log(GetComponent<Transform>().position);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            Debug.Log("ouch!");

        }
    }


}
