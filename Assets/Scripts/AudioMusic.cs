using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class AudioMusic : MonoBehaviour
{
    public static GameObject musicObject;
    private void Awake()
    {
        if (musicObject == null)
        {
            musicObject = this.gameObject;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {

     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
