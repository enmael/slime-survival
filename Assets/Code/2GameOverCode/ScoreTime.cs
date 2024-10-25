using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTime : MonoBehaviour
{
    public Text tiemScore;

    private void Start() 
    {
        int minutes = Mathf.FloorToInt(TimerUI.timer / 60); // 분 단위
        int seconds = Mathf.FloorToInt(TimerUI.timer % 60); // 초 단위
        tiemScore.text = string.Format("생존시간 : {0:00}:{1:00}", minutes, seconds);
    }

}
