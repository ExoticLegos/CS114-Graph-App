using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject HelpMenu;

    public void NextScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void ExitApp()
    {
        Application.Quit();
    }
    public void Help()
    {
        MainMenu.SetActive(false);
        HelpMenu.SetActive(true);
    }
    public void UnHelp()
    {
        MainMenu.SetActive(true);
        HelpMenu.SetActive(false);
    }
}
