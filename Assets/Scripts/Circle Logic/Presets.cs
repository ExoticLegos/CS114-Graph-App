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

    Vector3[] Preset3Circle = new[] { new Vector3(-0.05f, 0f, 187.0159f), new Vector3(2.59f, -2.49f, 187.0159f), new Vector3(-2.59f, -2.47f, 187.0159f), new Vector3(-2.79f, 2.11f, 187.0159f), new Vector3(2.69f, 2.14f, 187.0159f), new Vector3(5.13f, -0.15f, 187.0159f), new Vector3(-5.28f, -0.2f, 187.0159f), new Vector3(0f, 4.02f, 187.0159f), new Vector3(0f, -4.02f, 187.0159f) };
    int[,] Preset3Connect = new int[,] { { 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 3, 5, 9, 0, 0, 0 ,0 }, { 1, 2, 4, 7, 0, 0, 0, 0 }, { 1, 5, 3, 8, 0, 0, 0, 0 }, { 1, 4, 0, 6, 0, 0, 0, 0 }, { 5, 1, 0, 0, 0, 0, 0, 0 }, { 3, 1, 0, 0, 0, 0, 0, 0 }, { 4, 1, 0, 0, 0, 0, 0, 0 }, { 2, 1, 0, 0, 0, 0, 0, 0 } };
    int Colors3Min = 4;

    Vector3[] Preset4Circle = new[] { new Vector3(0.27f, 3.04f, 187.0159f), new Vector3(0.27f, -2.04f, 187.0159f), new Vector3(3.34f, 0.44f, 187.0159f), new Vector3(7.62f, 0.44f, 187.0159f), new Vector3(-2.97f, 0.44f, 187.0159f), new Vector3(-6.88f, 0.44f, 187.0159f)};
    int[,] Preset4Connect = new int[,] { { 3, 4, 5, 6 }, { 3, 4, 5, 6 }, { 1, 2, 4, 0 }, { 1, 2, 3, 0 }, { 1, 2, 6, 0 }, { 1, 2, 5, 0 } };
    int Colors4Min = 3;

    Vector3[] Preset5Circle = new[] { new Vector3(0.27f, 3.04f, 187.0159f), new Vector3(5.51f, 3.04f, 187.0159f), new Vector3(2.9f, 0.44f, 187.0159f), new Vector3(5.78f, -1.58f, 187.0159f), new Vector3(0.27f, -1.58f, 187.0159f), new Vector3(-3.55f, 0.44f, 187.0159f), new Vector3(-6.2f, 3.04f, 187.0159f), new Vector3(-6.2f, -1.58f, 187.0159f) };
    int[,] Preset5Connect = new int[,] { { 2, 6, 7 }, { 1, 3, 4 }, { 2, 4, 5 }, { 2, 3, 0 }, { 3, 6, 8 }, { 1, 7, 0 }, { 6, 8, 1 }, { 7, 5, 0 } };
    int Colors5Min = 3;


    private void Awake()
    {
        Preset = Random.Range(1, 6);


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
