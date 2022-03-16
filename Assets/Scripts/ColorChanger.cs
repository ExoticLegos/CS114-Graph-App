using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public GameObject controller;
    public Color32 StartColor = new Color32(255, 255, 255, 255);
    public Color32 AfterColor = new Color32(255, 52, 213, 255);

    public Color32 newColor;


    // Start is called before the first frame update
    void Start()
    {
        // Sets the color of the object to white on startup
        GetComponent<SpriteRenderer>().color = StartColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // Sets the newColor variable to the color set in the ButtonController script
        newColor = controller.GetComponent<ButtonController2>().currentColor;
        // Applies the new color to object
        GetComponent<SpriteRenderer>().color = newColor;

    }
}
