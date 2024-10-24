using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTime : MonoBehaviour
{
    public TimerUI timerUI;

    public Text text;
    public Text text2;

//     private void Awake() 
//     {
//         timerUI = GetComponent<TimerUI>();  
//     }

//     private void Start() 
//     {
//         TimerUI();
//         text.text = text2.text;
//     }

//    private void TimerUI()
//     {
//         // 시간 값을 분:초 형식으로 변환하여 UI에 표시
//         int minutes = Mathf.FloorToInt(timerUI.Timer / 60); // 분 단위
//         int seconds = Mathf.FloorToInt(timerUI.Timer % 60); // 초 단위
//         text2.text = string.Format("{0:00}:{1:00}", minutes, seconds);
//     }
}
