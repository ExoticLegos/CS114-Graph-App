using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController2 : MonoBehaviour
{

    private Button[] Buttons;

    public Color32 currentColor;

    // Start is called before the first frame update
    void Start()
    {
        // Gets the children button objects
        Buttons = GetComponentsInChildren<Button>();

        // Sets default color
        currentColor = new Color32(255, 52, 213, 255);
        
    }

    // Update is called once per frame
    void Update()
    {

    }


}
