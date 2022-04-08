using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartUp : MonoBehaviour
{
    public int Preset;
    public GameObject menuPrefab;
    public GameObject winMenuPrefab;
    private GameObject menu;
    private GameObject winMenu;
    public Camera cameraT;
    public GameObject PointController;

    private void Awake()
    {
        Preset = Random.Range(1, 5);
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(Resources.Load<Texture2D>("Cursors/" + gameObject.name), Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && menu == null)
        {
            CreateMenu();
        }
        if (PointController.GetComponent<PointLogic>().isGameWin && winMenu == null)
        {
            CreateWinMenu();
        }
    }


    void CreateMenu()
    {
        menu = Instantiate(menuPrefab, Vector3.zero, Quaternion.identity);
        menu.GetComponent<Canvas>().worldCamera = cameraT;
        Button[] Buttons = menu.GetComponentsInChildren<Button>();
        Buttons[0].GetComponent<Button>().onClick.AddListener(ExitApp);
        Buttons[1].GetComponent<Button>().onClick.AddListener(CloseMenu);
        Buttons[2].GetComponent<Button>().onClick.AddListener(MainMenu);
    }
    public void ExitApp()
    {
        Application.Quit();
    }
    public void CloseMenu()
    {
        Destroy(menu);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("TitleScene");
    }

    void CreateWinMenu()
    {
        winMenu = Instantiate(winMenuPrefab, Vector3.zero, Quaternion.identity);
        winMenu.GetComponent<Canvas>().worldCamera = cameraT;
        Button[] Buttons = winMenu.GetComponentsInChildren<Button>();
        Buttons[0].GetComponent<Button>().onClick.AddListener(ExitApp);
        Buttons[1].GetComponent<Button>().onClick.AddListener(MainMenu);
    }
}
