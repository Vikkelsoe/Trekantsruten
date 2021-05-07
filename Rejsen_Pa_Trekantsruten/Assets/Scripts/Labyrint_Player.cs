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
    
    public float speed = 2f; //styrer hastigheden på spilleren 
    Rigidbody2D rb;

    private void Start()
    {
        btn.onClick.AddListener(Restart); //Restart()-funktionen kaldes, når "Genstart"-knappen tændes
        rb = GetComponent<Rigidbody2D>(); //rigidbody-komponenten hentes fra spiller-GameObjectet
    }

    //Move() kaldes, når en af Event Trigger-komponenterne på de fire bevægelses-kanpper aktiveres. Event Trigger-komponenten sender et argument
    public void Move(string button)
    {
        //argumentet fra Event Triggeren opfanges i denne switch-case, og der dannes en vektor med den tilhørende bevægelse
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
            case "stop": //når der ikke længere trykkes på knappen, bliver argumentet "stop" sendt, og der dannes en nulvektor, som stopper bevægelsen
                rb.velocity = new Vector2(0, 0);
                break;

        }
    }

    //funktion kaldes, når spillerens collider støder sammen med en anden collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Key") //hvis objektet er tagget med "Key" fjernes objektet og den låste dør
        {
            Destroy(collision.gameObject);
            Destroy(door);
        }

        if (collision.gameObject.tag == "Enemies") //hvis objektet er tagget med "Enemy" vises en Game Over-skærm
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

    //når "Genstart"-knappen trykkes kaldes følgende funktion, som genindlæser siden
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
