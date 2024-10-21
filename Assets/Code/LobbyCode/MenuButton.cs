/*
# ----------------------------------------------------------------------------------------
#파일이름 :MenuButtons.cs
#작성자 : 장승배
#생성일 : 2024.10.21
#내용 : 버튼을 클릭했을때 버튼에 맞는 이벤트가 발생하느 코드이다 
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
//"GameScene"이라는 이름의 씬을 로드
public void StartGame()
{    
    SceneManager.LoadScene("GameScene");
}

 // 게임 종료
public void ExitGame()
{
    Application.Quit();
        
    Debug.Log("게임 종료");
}
}
