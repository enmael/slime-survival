/*
# ----------------------------------------------------------------------------------------
#파일이름 :RandoImage.cs
#작성자 : 장승배
#생성일 : 2024.11.08
#내용 :  ItemManager2.cs 에서 선정된 아이템을 이름을 가지고 그 아이템에 해당하는 이미지를 출력하는 코드이다.
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class RandoImage : MonoBehaviour
{
    public Image itmeImage;

    [SerializeField] List<Sprite> itemImages = new List<Sprite>(); 
    [SerializeField] ItemManager2 itemManager2;

    private bool itemManager2ItmeNameBool = true;  
    private string itmename;
    [SerializeField] bool StartingWeaponBool = false;

    [SerializeField] MonsterKillItem monsterKillItem;

    public bool StartingWeaponBools
    {
        get { return StartingWeaponBools;}

    }
    private void Start() 
    {
        itemImages.Capacity = 10;
    }

    private void Update() 
    {
        StartingWeaponImage();
        
        InGameItemImage();
    }

    private void StartingWeaponImage() //처음 시작 무기의 이미지를 출력하는코드
    {
        if(StartingWeaponBool == false)
        {
            itmename = itemManager2.StartWeaponName;

            for(int i = 0; i< itemImages.Count; i++)
            {
                if(itemImages[i].name == itmename)
                {
                    itmeImage.sprite = itemImages[i];   
                    break;
                }
            } 
        }
        StartingWeaponBool = true;
    }

    private void InGameItemImage() //시작 아이템 지급후 몬스터 100킬을 하면 새로운 아이템의 이미지를 출력하는 코드
    {
        if (StartingWeaponBool ==true && MonsterHp.monsteCount != 0 && MonsterHp.monsteCount %100 == 0)
        {
            itmename = monsterKillItem.newnewItmename;

            for(int i = 0; i< itemImages.Count; i++)
            {
                if(itemImages[i].name == itmename)
                {
                    itmeImage.sprite = itemImages[i];   
                    break;
                }
            } 
        }
    }
}
