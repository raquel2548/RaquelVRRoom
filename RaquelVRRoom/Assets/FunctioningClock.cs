using System.Collections;
using System;
using System.Globalization;
using System.Collections.Generic;
using UnityEngine;


public class FunctioningClock : MonoBehaviour
{
    public GameObject hourHand;
    public GameObject minuteHand;
    public GameObject secondHand;
    //string oldSeconds;

    void Update()
    {
        DateTime currentTime = DateTime.Now;
        float secondDegree = (currentTime.Second / 60f) * 360f;
        secondHand.transform.localRotation = Quaternion.Euler(new Vector3(secondDegree, 0, 0));
        float minuteDegree = (currentTime.Minute / 60f) * 360f;
        minuteHand.transform.localRotation = Quaternion.Euler(new Vector3(minuteDegree, 0, 0));
        float hourDegree = (currentTime.Hour / 60f) * 360f;
        hourHand.transform.localRotation = Quaternion.Euler(new Vector3(hourDegree, 0, 0));
        //string seconds = System.DateTime.UtcNow.ToString("ss");



    }

  //  void UpdateTimer()
    
        //int secondsInt = int.Parse(System.DateTime.UtcNow.ToString("ss"));
        //int minutesInt = int.Parse(System.DateTime.UtcNow.ToString("mm"));
        //int hoursInt = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("hh"));
        //print(hoursInt + " : " + minutesInt + " : " + secondsInt);

   
    //if (seconds != oldSeconds)
        
            //UpdateTimer();
        
        //oldSeconds = seconds;
}
