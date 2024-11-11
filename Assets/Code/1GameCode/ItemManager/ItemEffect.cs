/*
# ----------------------------------------------------------------------------------------
#파일이름 : ItemEffect.cs 
#작성자 : 장승배
#생성일 : 2024.11.11
#내용 :  추가로 지급된 아이템의 효과를 적용하는 코드이다.
# ------------------------------------------------------------------------------------------
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEffect : MonoBehaviour
{
    [SerializeField] MonsterHp monsterHp;
    [SerializeField] ItemManager3 itemManager3;
    [SerializeField] Damage damage;
    [SerializeField] Move move;
    [SerializeField] SelectButton2 selectButton2; 


    [SerializeField] int[]array = new int[4];   

    private void Update()
    {
        if(selectButton2.Effect == true)
        {
            SeparateItems();
            selectButton2.Effect = false;
        }
    }

    private void SeparateItems()
    {
        if (itemManager3.ItemName == "HpPotion")
        {
            damage.CurrentHealth = damage.CurrentHealth + 20;
        }
        if (itemManager3.ItemName == "SpeedPotion")
        {
            move.Speed = move.Speed + 3;   
        }
        if (itemManager3.ItemName == "Boxing")
        {
            array[0] = array[0] + 5;
            monsterHp.Damages = array[0];
        }
        if(itemManager3.ItemName == "SpinningSword")
        {
            array[1] = array[1] + 5;
            monsterHp.Damages = array[1];
        }
        if (itemManager3.ItemName == "ThrowAxe")
        {
            array[2] = array[2] + 5;
            monsterHp.Damages = array[2];
        }

    }
}
