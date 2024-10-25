/*
# ----------------------------------------------------------------------------------------
#파일이름 :Score.cs
#작성자 : 장승배
#생성일 : 2024.10.24
#내용 : 게임오버 하고 이때까지 죽인 몬스터의 숫자를 출력하는 코드
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text kiiText; 
    private void Start() 
    {
        kiiText.text = string.Format("킬:{0}", MonsterHp.monsteCount);
    }
    
}
