using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class CDUI : MonoBehaviour
{
    public Timer timer;
    public Slider cdBar;

    public float maxTime;



    void Start()
    {
        cdBar.value = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        //cdBar.value = timer.countDownTime;
    }
}
