/*
# ----------------------------------------------------------------------------------------
#파일이름 :GameOver.cs
#작성자 : 장승배
#생성일 : 2024.10.24
#내용 : hp 가 0 이되면 게임 오버 씬으로 씬을 전환하는 코드
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    Damage damage;
    public bool GameOverconte = false; 

      public bool GameOverConte
    {
      get { return GameOverconte; }
    }
    private void Awake() 
    {
        damage = GetComponent<Damage>();    
    }

    private void Update() {
        if (damage.CurrentHealth == 0)
        {
            SceneManager.LoadScene("GameOverScene");
            GameOverconte = true;   
        } 
    }    
 }
