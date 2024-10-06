using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public void Play(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
   
   
    public  void Quit()
    {
        Application.Quit();
        //EditorApplication.ExitPlaymode();
    }
}

