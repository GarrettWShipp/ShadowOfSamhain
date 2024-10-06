using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CDUI : MonoBehaviour
{
    public Attack attack;
    public Slider cdBar;


    public float maxTime;
   

    public float cdTime;
    






    void Start()
    {
        maxTime = attack.attackCooldown;
        cdBar.maxValue = maxTime;
        cdBar.value = 0;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        cdTime = attack.attackNext - Time.time;

        if (cdTime >= -1)
        {
            cdBar.value = cdTime;
        }
        
 
    }


}
