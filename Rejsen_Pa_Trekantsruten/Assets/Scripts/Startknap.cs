using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startknap : MonoBehaviour
{
    public void  btn_change_scene(string Vejledning)
    {

        SceneManager.LoadScene(Vejledning);

    }


}







