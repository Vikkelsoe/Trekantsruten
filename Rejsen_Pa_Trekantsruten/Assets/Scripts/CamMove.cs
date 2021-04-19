using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Her 
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 2);

    }

  
}
