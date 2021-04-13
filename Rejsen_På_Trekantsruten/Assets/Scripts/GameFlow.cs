using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    public Transform bricksObj;
    private Vector3 nextBrickSpawn;
    private int randx;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator spawn()
    {
        yield return new WaitForSeconds(1);
        randx = Random.Range(-1, 2);
        
        Instantiate(bricksObj, nextBrickSpawn, bricksObj.rotation);

    }




}
