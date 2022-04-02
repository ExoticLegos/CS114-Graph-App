using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointComparion : MonoBehaviour
{
    public GameObject PointController;
    //GameObject[] PointsToCompare;
    int[] PointsToCompare;
    public SpriteRenderer[] PRenderer;
    public int chrom;
    public bool isChromatic = false;



    // Start is called before the first frame update
    void Start()
    {
        PointController = GameObject.FindGameObjectWithTag("PointController");
        //PRenderer = PointController.GetComponent<PointLogic>().PRenderer;
        //PointsToCompare

        
    }

    // Update is called once per frame
    void Update()
    {
        chrom = 0;

        //for (int i = 0; i < PointsToCompare.Length-1; i++)
        //{
        //    if (PRenderer[i].color != PRenderer[i+1].color)
        //    {
        //        chrom++;
        //        if (chrom == PointsToCompare.Length)
        //        {
        //            isChromatic = true;
        //        }
        //        else
        //        {
        //            isChromatic = false;
        //        }
        //    }
        //}

    }

}
