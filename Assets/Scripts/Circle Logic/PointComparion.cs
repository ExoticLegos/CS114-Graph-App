using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointComparion : MonoBehaviour
{
    public GameObject PointController;
    GameObject[] PointsToCompare;
    SpriteRenderer[] PRenderer;



    // Start is called before the first frame update
    void Start()
    {
        PRenderer = PointController.GetComponent<PointLogic>().PRenderer;
    }

    // Update is called once per frame
    void Update()
    {
        //if (PRenderer[0].color == PRenderer[1].color)
        //{
        //    //Debug.Log("hello");
        //}

        //for (int i = 0; i < Points.Length-1; i++)
        //{
        //    if (PRenderer[i].color == PRenderer[i+1].color)
        //    {
        //        Debug.Log(i);
        //    }
        //}
    }
}
