using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Labyrint_Player : MonoBehaviour
{
    //der deklareres variabler til spilobjekter, som tildeles i inspektoren i Unity
    public GameObject door;
    public GameObject winPanel;
    public GameObject gameOverPanel;
    public GameObject arrows;
    public UnityEngine.UI.Button btn;
    
    public float speed = 2f; //styrer hastigheden p� spilleren 
    Rigidbody2D rb;

    private void Start()
    {
        btn.onClick.AddListener(Restart); //Restart()-funktionen kaldes, n�r "Genstart"-knappen t�ndes
        rb = GetComponent<Rigidbody2D>(); //rigidbody-komponenten hentes fra spiller-GameObjectet
    }

    //Move() kaldes, n�r en af Event Trigger-komponenterne p� de fire bev�gelses-kanpper aktiveres. Event Trigger-komponenten sender et argument
    public void Move(string button)
    {
        //argumentet fra Event Triggeren opfanges i denne switch-case, og der dannes en vektor med den tilh�rende bev�gelse
        switch (button)
        {
            case "up":
                rb.velocity = new Vector2(0, 1 * speed);
                break;
            case "down":
                rb.velocity = new Vector2(0, -1 * speed);
                break;
            case "left":
                rb.velocity = new Vector2(-1 * speed, 0);
                break;
            case "right":
                rb.velocity = new Vector2(1 * speed, 0);
                break;
            case "stop": //n�r der ikke l�ngere trykkes p� knappen, bliver argumentet "stop" sendt, og der dannes en nulvektor, som stopper bev�gelsen
                rb.velocity = new Vector2(0, 0);
                break;

        }
    }

    //funktion kaldes, n�r spillerens collider st�der sammen med en anden collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Key") //hvis objektet er tagget med "Key" fjernes objektet og den l�ste d�r
        {
            Destroy(collision.gameObject);
            Destroy(door);
        }

        if (collision.gameObject.tag == "Enemies") //hvis objektet er tagget med "Enemy" vises en Game Over-sk�rm
        {
            gameOverPanel.SetActive(true);
        }

        if (collision.gameObject.tag == "Goal") //hvis objektet er tagget med "Goal" skjules spilleren og styre-tasterne, mens et winPanel vises
        {
            this.gameObject.SetActive(false);
            winPanel.SetActive(true);
            arrows.SetActive(false);
        }
    }

    //n�r "Genstart"-knappen trykkes kaldes f�lgende funktion, som genindl�ser siden
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // En snydeknap, til hurtigt at komme igennem spillet.
    public void Cheat()
    {
        this.transform.position = new Vector3(-0.5f, 4.25f, 0);
        GameObject.Find("Snyd").SetActive(false);
    }
}
