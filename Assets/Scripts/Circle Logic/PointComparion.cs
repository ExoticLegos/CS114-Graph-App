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
    public GameObject Outline;
    public GameObject isOutline;
    Color32 colorChange;



    // Start is called before the first frame update
    void Start()
    {
        // Finds the point objects and adds them to and array
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

        Outline = Resources.Load<GameObject>("Prefabs/Outline");
    }

    // Update is called once per frame
    void Update()
    {
        chrom = 0;
        colorChange = GetComponent<SpriteRenderer>().color;

        // Checks if each point in the array is chromatic by comparing its color to the connected points colors
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
                }
            }
            
        }
        if (chrom != PointsToCompare.Length - Zeros)
        {
            isChromatic = false;
        }

        if (isOutline == null && isChromatic == true)
        {
            isOutline = Instantiate(Outline, new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z + 0.22f), Quaternion.identity, GetComponent<Transform>());
            isOutline.GetComponent<SpriteRenderer>().color = new Color32(111, 241, 142, 255);
        }
        if (isChromatic == false && isOutline != null)
        {
            Destroy(isOutline);
        }

    }



}
