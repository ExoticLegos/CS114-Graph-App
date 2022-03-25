using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCreator : MonoBehaviour
{

    public GameObject Point;
    public Transform parent;

    public GameObject[] Points;

    Vector3[] positions = new[] { new Vector3(4.16f, 2.425f, 187.0159f), new Vector3(-4.161f, 2.425f, 187.0159f), new Vector3(-4.161f, -3.574f, 187.0159f), new Vector3(4.16f, -3.574f, 187.0159f) };


    private void Awake()
    {
        for (int i = 0; i < positions.Length; i++)
        {
            Instantiate(Point, positions[i], Quaternion.identity, parent);
        }
    }

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
}
