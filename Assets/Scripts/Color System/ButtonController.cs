using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Color32 color;
    public Color32 colorChange;


    private void Awake()
    {
        // Sets the tag of the button 
        gameObject.tag = "Button";
    }

    // Start is called before the first frame update
    void Start()
    {
        // Created the TaskOnClick event listener
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        // Gets the buttons color from button component
        color = GetComponent<Button>().colors.normalColor;
    }

    // Update is called once per frame
    void Update()
    {
      

    }

    public void TaskOnClick()
    {   
        colorChange = color;

        // Gets the Button Controller game object
        GameObject buttonController = GameObject.FindGameObjectWithTag("ButtonController");
        // Sets the selected color
        buttonController.GetComponent<SelectedColor>().currentColor = color;


        // Finds the object with the outline tag
        GameObject outline = GameObject.FindGameObjectWithTag("Outline");
        // Moves the outline object to the position of the button
        outline.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+0.001f);
        // Changes the color of the outline to a darker version of the button color
        if (colorChange.r <= 34)
        {
            outline.GetComponent<SpriteRenderer>().color = new Color32( 0, 0, 0, 255);
        }
        else
        {
            outline.GetComponent<SpriteRenderer>().color = new Color32(colorChange.r -= 35, colorChange.g -= 35, colorChange.b -= 35, 255);
        }

        // Changes the cursor to the new color
        Cursor.SetCursor(Resources.Load<Texture2D>("Cursors/" + gameObject.name), Vector2.zero, CursorMode.Auto);

    }
}
