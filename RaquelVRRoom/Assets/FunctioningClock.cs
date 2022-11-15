using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FunctioningClock : MonoBehaviour
{
    public GameObject hourhand;
    public GameObject minutehand;
    public GameObject secondhand;
    string oldSeconds;

    void Update()
    {
        string seconds = System.DateTime.UtcNow.ToString("ss");
        

        if (seconds != oldSeconds)
        {
            UpdateTimer();
        }
        oldSeconds = seconds;
    }

    void UpdateTimer()
    {
        int secondsInt = int.Parse(System.DateTime.UtcNow.ToString("ss"));
        int minutesInt = int.Parse(System.DateTime.UtcNow.ToString("mm"));
        int hoursInt = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("hh"));
        print(hoursInt + " : " + minutesInt + " : " + secondsInt);

       // Rotate(secondhand, ("z", secondsInt * 6 * -1));
       // Rotate(minutehand, ("z", minutesInt * 6 * -1));
       // float hourDistance = (float)(minutesInt) / 60f;
       // Rotate(hourhand, ("z", (hoursInt + hourDistance) * 360 / 12 * -1));
    }
}
