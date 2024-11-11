/*
# ----------------------------------------------------------------------------------------
#파일이름 : MonsterKillItem.cs 
#작성자 : 장승배
#생성일 : 2024.11.08
#내용 :  - 몬스터 킬수가100을 넘으면 아이템을 지급하는 코드이다.
# ------------------------------------------------------------------------------------------
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterKillItem : MonoBehaviour
{
    [SerializeField] List <GameObject>itemList = new List<GameObject>(); 
    [SerializeField] GameObject canvasOject;

    [SerializeField] int randomIndex;
    [SerializeField] string itmename;

    private bool onceBool = true;

    public bool OnceBool
    {
        get { return onceBool; }
        set { onceBool = value; }    
    }

    public string newnewItmename
    {
        get { return itmename; }    
    }
    private void Awake() 
    {
        itemList.Capacity = 10;
    }  

    private void Update() 
    {
        MonsterKillCount();
    }


    private void MonsterKillCount()
    {
        //int numberCount = 100;
        if(MonsterHp.monsteCount != 0 && MonsterHp.monsteCount % 100 == 0) 
        {
            if(onceBool == true)
            {
                ItemRandomSelection();
                Time.timeScale = 0f;
                canvasOject.SetActive(true); 
                onceBool = false;
                
            }
            
        }  
    }

    private void ItemRandomSelection()
    {
        randomIndex = UnityEngine.Random.Range(0, itemList.Count);
        itmename = itemList[randomIndex].name;

    }
}
