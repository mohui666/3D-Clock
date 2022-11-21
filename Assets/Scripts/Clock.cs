using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour 
{
    const float hoursToDegrees = -30f,minutesToDegrees = -6f,secondsToDegrees = -6f;
    [SerializeField]
    Transform hoursPivots = default,minutesPivots = default,secondsPivots = default;

    void Update ()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivots.localRotation = 
            Quaternion.Euler(0f,0f,hoursToDegrees * (float)time.TotalHours);
        minutesPivots.localRotation = 
            Quaternion.Euler(0f,0f,minutesToDegrees * (float)time.TotalMinutes);
        secondsPivots.localRotation = 
            Quaternion.Euler(0f,0f,secondsToDegrees * (float)time.TotalSeconds);
    }
}
