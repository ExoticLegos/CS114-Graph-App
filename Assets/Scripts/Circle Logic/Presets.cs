using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presets : MonoBehaviour
{
    public int Preset;
    public int[,] PointsPreset;

    public int[,] Preset1;
    public int[,] Preset2;
    public int[,] Preset3;
    public int[,] Preset4;
    public int[,] Preset5;

    private void Awake()
    {
        Preset = Random.Range(1, 5);

        // Sets PointPreset to the array of the randomly selected number
        switch (Preset)
        {
            case 1:
                PointsPreset = Preset1;
                break;
            case 2:
                PointsPreset = Preset2;
                break;
            case 3:
                PointsPreset = Preset3;
                break;
            case 4:
                PointsPreset = Preset4;
                break;
            case 5:
                PointsPreset = Preset5;
                break;

            default:
                break;
        }
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
