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
        chromCount = Points.GetComponent<PointLogic>().chromCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GetComponent<Text>().text = "Colors Used: " + colors + "/" + colorsTotal + "\nChromatic Points: " + chromCount + "/" + chromTotal;
    }
}
