using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerBehaviour : MonoBehaviour
{
    public GameObject seconds;
    public GameObject minutes;
    public GameObject hours;
    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
        seconds.transform.localRotation = Quaternion.Euler((360 / 60) * time.Second, seconds.transform.rotation.y, -90);
        minutes.transform.localRotation = Quaternion.Euler((360 / 60) * time.Minute,  minutes.transform.rotation.y, -90);
        hours.transform.localRotation = Quaternion.Euler((360 / 12) * time.Hour, hours.transform.rotation.y, -90);
    }
}
