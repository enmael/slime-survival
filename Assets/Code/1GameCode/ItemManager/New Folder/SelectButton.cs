/*
# ----------------------------------------------------------------------------------------
#파일이름 : SelectButton.cs 
#작성자 : 장승배
#생성일 : 2024.11.08
#내용 :  버튼을 누르면 지급된 아이템을 사용하고 캠퍼스를 비활성화 하면서 게임을 제 가동하는 코드이다.
# ------------------------------------------------------------------------------------------
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectButton : MonoBehaviour
{
    [SerializeField]bool selectBool = false;


    [SerializeField]bool selectBool2 = true;
    //[SerializeField] Canvas canvas;

    [SerializeField] GameObject canvasOject;

    [SerializeField] MonsterKillItem monsterKillItem;
    public bool SelectBool
    {
        get { return selectBool; }
    }

    public bool SelectBool2
    {
        get { return selectBool2; }
        set { selectBool2 = value; } 
    }


    public void selectButton()
    {
        selectBool = true;
        //canvas.enabled = false;
        canvasOject.SetActive(false);
        MonsterHp.monsteCount++; 
        Time.timeScale = 1f;
        monsterKillItem.OnceBool = true;
        selectBool2 = true;


    }
}
