using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TimerController : MonoBehaviour
{
    public static TimerController instance;

    public Text timerCounter;

    private TimeSpan timePlaying;
    private bool timerGoing;

    private float elapsedTime;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        timerCounter.text = "TIME: 00:00.00";
        timerGoing = false;
    }

    public void BeginTimer()
    {
        timerGoing = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void PauseTimer()
    {
        timerGoing = false;
    }

    public void ResumeTimer()
    {
        timerGoing = true;
        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        timerGoing = false;
        GameController.instance.gamePlaying = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime); //converts float into TimeSpan format
            string timePlayingStr = "TIME: " + timePlaying.ToString("mm':'ss'.'ff"); //format TimeSpan (https://docs.microsoft.com/en-us/dotnet/api/system.timespan.tostring?view=netframework-4.8#System_TimeSpan_ToString_System_String_)
            timerCounter.text = timePlayingStr;

            yield return null;
        }
    }
}
