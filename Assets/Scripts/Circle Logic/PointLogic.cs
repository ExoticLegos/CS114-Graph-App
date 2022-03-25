using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLogic : MonoBehaviour
{
    public GameObject PointController;
    public GameObject StartUp;
    GameObject[] Points;
    public SpriteRenderer[] PRenderer;


    bool[] isChromatic = new bool[] { };
    public int chromTotal;
    public int chromCount;

    // Start is called before the first frame update
    void Start()
    {
        chromTotal = StartUp.GetComponent<StartUp>().Preset + 2;
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
        //Debug.Log(chromCount);
    }
}
