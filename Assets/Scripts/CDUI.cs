using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class CDUI : MonoBehaviour
{
    public Attack attack;
    public Slider cdBar;

    public float maxTime;
    public float attackCooldown;

    public string keypress;



    void Start()
    {
        cdBar.maxValue = maxTime;
        cdBar.value = 0;

    }

    // Update is called once per frame
    void Update()
    {
        cdBar.value = attackCooldown;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attackCooldown -= 1;
        }
    }


}
