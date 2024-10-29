/*
# ----------------------------------------------------------------------------------------
#파일이름 :TimerUI.cs
#작성자 : 장승배
#생성일 : 2024.10.10
#내용 : 플레이 시간을 기록하요 저장 
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
  
  public Text timerText; // UI Text 컴포넌트 연결
  public static int  timer;

  public int ReturnTimer
  {
    get { return timer; } 
  }

  void Start()
  {
    StartCoroutine(TimeCoroutine());
  }

  private IEnumerator TimeCoroutine()
    {
      while(true)
      {
        yield return new WaitForSeconds(1);
         
          Timer();
      }  

    }
    
  void Timer()
    {
       timer++;
        // 시간 값을 분:초 형식으로 변환하여 UI에 표시
        int minutes = Mathf.FloorToInt(timer / 60); // 분 단위
        int seconds = Mathf.FloorToInt(timer % 60); // 초 단위
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        //returnText.text = timerText.text;
    }
}
