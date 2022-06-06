using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMain : MonoBehaviour
{
    [Header("UIPages")]
    public GameObject settingsScreen;
    public GameObject mainScreen;
    public GameObject audioScreen;
    public GameObject graphicsScreen;
    public void StartGame()
    {
        SceneManager.LoadScene("Playground");
    }

    public void Settings()
    {
        mainScreen.SetActive(false);
        settingsScreen.SetActive(true);
    }

    public void BackToMain()
    {
        settingsScreen.SetActive(false);
        audioScreen.SetActive(false);
        graphicsScreen.SetActive(false);
        mainScreen.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
