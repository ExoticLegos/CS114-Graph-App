using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    public GameObject[] circles;
    public Vector3[] circlePositions;
    public LineRenderer[] lines;

    private int[,] connections; // array of numbers such as [1, 3, 2] that connects those number points together using a for/each loop (1st point to 3rd point 3rd to 2nd etc)

    // Start is called before the first frame update
    void Start()
    {
        connections = GetComponent<Presets>().ConnectPreset;

        circles = GameObject.FindGameObjectsWithTag("Point");
        lines = new LineRenderer[circles.Length];


        circlePositions = new Vector3[circles.Length];
        for (int i = 0; i < circles.Length; i++)
        {
            circlePositions[i] = new Vector3(circles[i].transform.position.x, circles[i].transform.position.y, 187.0159f);
        }

        for (int i = 0; i < circles.Length; i++)
        {
            lines[i] = circles[i].GetComponent<LineRenderer>();
        }

        for (int i = 0; i < connections.GetUpperBound(0)+1; i++)
        {
            lines[i].positionCount = (connections.GetUpperBound(1)+1)*2 + 1;

            for (int k = 0; k < (connections.GetUpperBound(1)+1)*2 + 1; k++)
            {
                lines[i].SetPosition(k, circlePositions[i]);
            }
            for (int j = 0; j < connections.GetUpperBound(1)+1; j++)
            {
                if (connections[i, j] != 0)
                {
                    lines[i].SetPosition(j*2, circlePositions[i]);
                    lines[i].SetPosition(j*2+1, circlePositions[connections[i,j]-1]);
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
    }



}
