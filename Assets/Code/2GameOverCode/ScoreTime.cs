/*
# ----------------------------------------------------------------------------------------
#파일이름 :ScoreTime.cs
#작성자 : 장승배
#생성일 : 2024.10.24
#내용 : 생존한 시간을 게임이 오버 되고 Text에 출력하는 코드이다.
# ------------------------------------------------------------------------------------------
*/

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
