using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void ExitApp()
    {
        Application.Quit();
    }
}
