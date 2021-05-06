using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    void Start()
    {
        // Her 
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 2);

    }

  
}
