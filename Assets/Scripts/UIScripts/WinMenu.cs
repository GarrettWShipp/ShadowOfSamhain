
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{

    public GameObject winScreen;

    public void WinScreen()
    {
        winScreen.SetActive(true);
    }


    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}


