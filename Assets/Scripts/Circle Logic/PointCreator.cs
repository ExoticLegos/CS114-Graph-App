using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCreator : MonoBehaviour
{

    public GameObject Point;
    public Transform parent;

    public GameObject[] Points;

    Vector3[] positions;


    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        Points = GameObject.FindGameObjectsWithTag("Point");
        foreach (GameObject P in Points)
        {
            i++;
            P.name = i.ToString();
            P.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PointCreation()
    {
        Vector3[] positions = GetComponent<Presets>().PointsPreset;

        for (int i = 0; i < positions.Length; i++)
        {
            Instantiate(Point, new Vector3(positions[i].x + 1.16f, positions[i].y + 0.6f, 187.0159f), Quaternion.identity, parent);
        }
    }
}
