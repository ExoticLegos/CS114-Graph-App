using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Specify the keycodes in the inspector
    public KeyCode[] KeyCodeSeries = new KeyCode[] { KeyCode.A, KeyCode.M, KeyCode.O, KeyCode.N, KeyCode.G, KeyCode.U, KeyCode.S };

    // Use this if you want the user to press the series of keys in a given times interval
    public float DelayBeforeReset = 86400; // = One day

    // Specify in the inspector the function you want to call
    // after the series have been completed
    public UnityEngine.Events.UnityEvent OnSeriesComplete;

    // Specify in the inspector the function you want to call
    // after the series have been failed because a wrong key has been pressed
    public UnityEngine.Events.UnityEvent OnSeriesFailed;

    // Specify in the inspector the function you want to call
    // after the series have been failed because the user did not pressed the key before the end of the delay
    public UnityEngine.Events.UnityEvent OnTimeRunnedOut;
    // The index in the array of the next key to press in order to continue the series
    private int keyCodeIndex;
    // The time (in seconds) the last correct key has been pressed
    private float lastKeyPressTime;

    Sprite[] textures;

    private void Start()
    {
        //textures = Resources.LoadAll<Sprite>("Images");
        //GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/amongus");
    }


    private void Update()
    {
        // Make sure some keys have been specified in the inspector 
        if (KeyCodeSeries.Length == 0)
            return;

        // Check if the user pressed the key before the end of the timer
        if (Time.time - lastKeyPressTime > DelayBeforeReset)
        {
            keyCodeIndex = 0;
            if (OnTimeRunnedOut != null)
            {
                //OnTimeRunnedOut.Invoke();
            }

        }

        // Correct key pressed!
        if (Input.GetKeyDown(KeyCodeSeries[keyCodeIndex]))
        {
            lastKeyPressTime = Time.time;
            keyCodeIndex++;

            // Series completed!
            if (keyCodeIndex >= KeyCodeSeries.Length)
            {
                if (OnSeriesComplete != null)
                    //OnSeriesComplete.Invoke();

                // Reset index to allow to start again
                keyCodeIndex = 0;



                //textures = Resources.LoadAll<Sprite>("Images");
                //GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/amongus");


                Cursor.SetCursor(Resources.Load<Texture2D>("Images/amongusCur"), Vector2.zero, CursorMode.Auto);





            }
        }
        // Wrong key pressed!
        else if (Input.anyKeyDown)
        {
            keyCodeIndex = 0;
            if (OnSeriesFailed != null)
            {
                //OnSeriesFailed.Invoke();
            }

        }



    }

}
