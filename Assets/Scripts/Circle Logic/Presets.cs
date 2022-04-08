using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presets : MonoBehaviour
{
    public int Preset;
    public Vector3[] PointsPreset;
    public int[,] ConnectPreset;
    public int MinColors;

    Vector3[] Preset1Circle = new[] { new Vector3(-1.19f, -0.6f, 187.0159f), new Vector3(3.16f, 2.425f, 187.0159f), new Vector3(-5.161f, 2.425f, 187.0159f), new Vector3(-5.161f, -3.574f, 187.0159f), new Vector3(3.16f, -3.574f, 187.0159f), new Vector3(6.9f, -0.6f, 187.0159f) };
    int[,] Preset1Connect = new int[,] { { 2, 5, 0 }, { 1, 3, 6 }, { 2, 4, 0 }, { 3, 5, 0 }, { 4, 1, 6 }, { 5, 2, 0 } };
    int Colors1Min = 3;
    Vector3[] Preset2Circle = new[] { new Vector3(0f, 0f, 187.0159f), new Vector3(-3f, 3f, 187.0159f), new Vector3(-5f, 0f, 187.0159f), new Vector3(-3f, -3f, 187.0159f), new Vector3(3f, -3f, 187.0159f), new Vector3(5f, 0f, 187.0159f), new Vector3(3f, 3f, 187.0159f) };
    int[,] Preset2Connect = new int[,] { { 2, 3, 7 }, { 1, 3, 7 }, { 1, 2, 4 }, { 3, 5, 6 }, { 4, 6, 0 }, { 4, 5, 7 }, { 1, 2, 6 } };
    int Colors2Min = 3;
    Vector3[] Preset3Circle;
    int[,] Preset3Connect;
    int Colors3Min = 0;
    Vector3[] Preset4Circle;
    int[,] Preset4Connect;
    int Colors4Min = 0;
    Vector3[] Preset5Circle;
    int[,] Preset5Connect;
    int Colors5Min = 0;


    private void Awake()
    {
        Preset = Random.Range(1, 3);
        //Preset = 2;

        // Sets PointPreset to the array of the randomly selected number
        switch (Preset)
        {
            case 1:
                PointsPreset = Preset1Circle;
                ConnectPreset = Preset1Connect;
                MinColors = Colors1Min;
                break;
            case 2:
                PointsPreset = Preset2Circle;
                ConnectPreset = Preset2Connect;
                MinColors = Colors2Min;
                break;
            case 3:
                PointsPreset = Preset3Circle;
                ConnectPreset = Preset3Connect;
                MinColors = Colors3Min;
                break;
            case 4:
                PointsPreset = Preset4Circle;
                ConnectPreset = Preset4Connect;
                MinColors = Colors4Min;
                break;
            case 5:
                PointsPreset = Preset5Circle;
                ConnectPreset = Preset5Connect;
                MinColors = Colors5Min;
                break;

            default:
                break;
        }

        GetComponent<PointCreator>().PointCreation();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
