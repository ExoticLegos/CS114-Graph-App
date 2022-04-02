using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorReset : MonoBehaviour
{

    public GameObject[] Points;

    // Start is called before the first frame update
    void Start()
    {
        Points = GameObject.FindGameObjectsWithTag("Point");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClearColors()
    {
        foreach (GameObject but in Points)
        {
            but.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
        }
    }


}
