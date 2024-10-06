using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public TMP_Text text;

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
   
   
    public  void Quit()
    {
        Application.Quit();
        EditorApplication.ExitPlaymode();
    }
}

