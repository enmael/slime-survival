using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
  
  public Text timerText; // UI Text 컴포넌트 연결
  private int  timer;
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
