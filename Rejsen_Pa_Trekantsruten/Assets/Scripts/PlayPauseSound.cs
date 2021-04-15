using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPauseSound : MonoBehaviour
{
    public AudioSource sound;
    Button btn;
    bool isStarted;
    bool isPlaying;

    private void Start()
    {
        isStarted = false;
        isPlaying = false;
        btn = this.GetComponent<Button>();
    }

    // TaskOnClick is called When the Button is clicked
    public void TaskOnClick()
    {
        if (!isStarted)
        {
            sound.Play();
            isStarted = true;
            isPlaying = true;
        } else if (isStarted && isPlaying)
        {
            sound.Pause();
            isPlaying = false;
        } else if (isStarted && !isPlaying)
        {
            sound.UnPause();
            isPlaying = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
