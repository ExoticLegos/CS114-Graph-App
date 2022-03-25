using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUp : MonoBehaviour
{
    public int Preset;

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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
