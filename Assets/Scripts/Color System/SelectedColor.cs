using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedColor : MonoBehaviour
{

    private Button[] Buttons;

    public Color32 currentColor;
    public string currentColorName = "White";

    // Start is called before the first frame update
    void Start()
    {
        // Gets the children button objects
        Buttons = GetComponentsInChildren<Button>();

        // Sets default color
        currentColor = new Color32(255, 255, 255, 255);
        
    }

    // Update is called once per frame
    void Update()
    {

    }


}
