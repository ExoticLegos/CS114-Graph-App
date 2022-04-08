using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointComparion : MonoBehaviour
{
    public GameObject PointController;
    //GameObject[] PointsToCompare;
    public int[] PointsToCompare;
    public SpriteRenderer[] PRenderer;
    public int chrom;
    public bool isChromatic = false;
    int Zeros = 0;



    // Start is called before the first frame update
    void Start()
    {
        PointController = GameObject.FindGameObjectWithTag("PointController");
        PRenderer = PointController.GetComponent<PointLogic>().PRenderer;
        PointsToCompare = new int[PointController.GetComponent<Presets>().ConnectPreset.GetUpperBound(1) + 1];

        for (int i = 0; i < PointController.GetComponent<Presets>().ConnectPreset.GetUpperBound(1)+1; i++)
        {
            PointsToCompare[i] = PointController.GetComponent<Presets>().ConnectPreset[int.Parse(gameObject.name)-1, i];
        }
        for (int i = 0; i < PointsToCompare.Length; i++)
        {
            if (PointsToCompare[i] == 0)
            {
                Zeros += 1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        chrom = 0;
        

        for (int i = 1; i < PointsToCompare.Length+1; i++)
        {
            if (PointsToCompare[i-1] != 0)
            {
                if (GetComponent<SpriteRenderer>().color != PRenderer[PointsToCompare[i - 1] - 1].color)
                {
                    chrom++;
                    if (chrom == PointsToCompare.Length - Zeros)
                    {
                        isChromatic = true;
                    }
                    else
                    {
                        isChromatic = false;
                    }
                }
            }
            
        }

    }



}
