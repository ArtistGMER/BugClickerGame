using TMPro;
using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GameTimer : MonoBehaviour
{
    public float remainingTime = 60f;
    public TextMeshProUGUI TimerDisplay;
    void Start()
    {
        
    }

    void Update()
    {
        if(remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            UpdateTimerDisplay(remainingTime);

        }


        else
        {
            remainingTime = 0;
            TimerDisplay.text = "00:00";

        }
    }

    void UpdateTimerDisplay(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        TimerDisplay.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
