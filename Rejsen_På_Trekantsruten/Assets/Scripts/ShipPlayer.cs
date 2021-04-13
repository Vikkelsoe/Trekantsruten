using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPlayer : MonoBehaviour
{

    public GameObject obj;
    Vector3 camPos;
    Vector3 startPos;
    float speed = 3;

    public float length;
    

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        //offset = obj.transform.position;
        GetComponent<Rigidbody>().velocity = new Vector3(0,0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = camPos + offset;   

        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, length)+1.5f, transform.position.z);

    }
}
