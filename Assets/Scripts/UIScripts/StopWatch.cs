
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class StopWatch : MonoBehaviour
{
    public bool timerActive = true;
    public float currentTime = 0;

    public TMP_Text timerText;
    public TMP_Text finalTime;
    void Start()
    {
        
    }


    void FixedUpdate()
    {
        if (timerActive)
        {
            currentTime +=  Time.deltaTime; 
        }

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timerText.text = "Time: "+ time.Minutes.ToString()+ ":"+ time.Seconds.ToString() + ":" + time.Milliseconds.ToString();
        finalTime.text = "Final Time: " + time.Minutes.ToString() + ":" + time.Seconds.ToString() + ":"+ time.Milliseconds.ToString();
    }
}
