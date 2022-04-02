using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PointLogic : MonoBehaviour
{
    public GameObject PointController;
    public GameObject StartUp;
    GameObject[] Points;
    public SpriteRenderer[] PRenderer;


    bool[] isChromatic = new bool[] { };
    public int chromTotal;
    public int chromCount;
    Color[] colorsArray;
    public int colorsTotal;

    // Start is called before the first frame update
    void Start()
    {
        chromTotal = PointController.GetComponent<Presets>().PointsPreset.Length;

        Points = PointController.GetComponent<PointCreator>().Points;
        PRenderer = new SpriteRenderer[Points.Length];

        for (int i = 0; i < Points.Length; i++)
        {
            PRenderer[i] = Points[i].GetComponent<SpriteRenderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        chromCount = 0;

        foreach (bool chrom in isChromatic)
        {
            if (chrom)
            {
                chromCount += 1;
            }
        }

        for (int i = 0; i < Points.Length; i++)
        {
            PRenderer[i] = Points[i].GetComponent<SpriteRenderer>();
        }


        ColorCounter();
    }

    void ColorCounter()
    {
        PRenderer = PointController.GetComponent<PointLogic>().PRenderer;
        colorsArray = new Color[PRenderer.Length];

        for (int i = 0; i < PRenderer.Length; i++)
        {
            colorsArray[i] = PRenderer[i].color;
        }

        colorsTotal = colorsArray.Distinct().Count();
    }
}
