using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public DownMove downMove;
    public UpMove upMove;
    public RightMove rightMove;
    public LeftMove leftMove;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Walls")
        {
            downMove.undoDown();
            upMove.undoUp();
            rightMove.undoRight();
            leftMove.undoLeft();
        }

        if(collision.gameObject.tag == "Key")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Enemies")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
