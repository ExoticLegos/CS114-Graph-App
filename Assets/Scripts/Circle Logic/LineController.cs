using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    public GameObject[] circles;
    public Vector3[] circlePositions;
    public LineRenderer[] lines;

    private int[] connections; // array of numbers such as [1, 3, 2] that connects those number points together using a for/each loop (1st point to 3rd point 3rd to 2nd etc)

    // Start is called before the first frame update
    void Start()
    {
        circles = GameObject.FindGameObjectsWithTag("Point");
        lines = new LineRenderer[circles.Length];
        for (int i = 0; i < circles.Length; i++)
        {
            lines[i] = circles[i].GetComponent<LineRenderer>();
        }
        
        circlePositions = new Vector3[circles.Length];
        for (int i = 0; i < circles.Length; i++)
        {
            circlePositions[i] = new Vector3(circles[i].transform.position.x, circles[i].transform.position.y, 187.0159f);
        }

        for (int i = 0; i < circles.Length-1; i++)
        {
            lines[i].SetPosition(0, circlePositions[i]);
            lines[i].SetPosition(1, circlePositions[i + 1]);
        }
        lines[circles.Length-1].SetPosition(0, circlePositions[circles.Length-1]);
        lines[circles.Length-1].SetPosition(1, circlePositions[0]);
    }

    // Update is called once per frame
    void Update()
    {
    }

    // for loop that runs for circle array length -1 then after loop ends does one more connection for the last in the array and the first in the array
    // circles as a child and use getcomponene in child
    // check if circles that are next to each other in the array are the same color or not
    // for random generation have preset scripts for each possible generation and have one randomly picked and have points generated based on the script
    // for example on script caould have the 3rd and 5th points in the array be connected, or another having the 2nd and 7th points connected, or doesnt have the first and last point connected
    // or for no randomization have preset scripts and points generated


}
