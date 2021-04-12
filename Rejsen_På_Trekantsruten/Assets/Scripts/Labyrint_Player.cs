using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Labyrint_Player : MonoBehaviour
{

    public float speed = 2f;

    Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(string button)
    {
        switch (button)
        {
            case "up":
                rb.velocity = new Vector2(0, 1 * speed);
                Debug.Log("up");
                break;
            case "down":
                rb.velocity = new Vector2(0, -1 * speed);
                Debug.Log("down");
                break;
            case "left":
                rb.velocity = new Vector2(-1 * speed, 0);
                Debug.Log("left");
                break;
            case "right":
                rb.velocity = new Vector2(1 * speed, 0);
                Debug.Log("right");
                break;
            case "stop":
                rb.velocity = new Vector2(0, 0);
                break;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
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
