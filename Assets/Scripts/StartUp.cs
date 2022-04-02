using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartUp : MonoBehaviour
{
    public int Preset;
    public GameObject menuPrefab;
    private GameObject menu;
    public Camera cameraT;

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
}
