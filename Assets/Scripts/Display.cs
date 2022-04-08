using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    private int chromTotal;
    private int chromCount;
    private int colors;
    private int colorsTotal;

    public GameObject Points;

    // Start is called before the first frame update
    void Start()
    {
        chromTotal = Points.GetComponent<PointLogic>().chromTotal;
        colorsTotal = Points.GetComponent<Presets>().MinColors;
    }

    // Update is called once per frame
    void Update()
    {
        colors = Points.GetComponent<PointLogic>().colorsTotal;
        chromCount = Points.GetComponent<PointLogic>().chromCount;
    }

    private void OnGUI()
    {
        GetComponent<Text>().text = "Colors Used: " + colors + "/" + colorsTotal + "\nChromatic Points: " + chromCount + "/" + chromTotal;
    }
}
