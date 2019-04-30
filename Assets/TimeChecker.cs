using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeChecker : MonoBehaviour
{
    public Text timeLeft;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = 120 - Time.time - startTime;

        string minutes = ((int)t / 60).ToString("00");
        string seconds = ((int)t % 60).ToString("00");

        timeLeft.text = minutes + ":" + seconds;
    }
}
