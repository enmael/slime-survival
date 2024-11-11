/*
# ----------------------------------------------------------------------------------------
#파일이름 : ItemPayment.cs
#작성자 : 장승배
#생성일 : 2024.11.08
#내용 :  할당 받은 아이템을 사용하는 코드이다
# ------------------------------------------------------------------------------------------
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPayment : MonoBehaviour
{
    [SerializeField] List<GameObject>  potionList = new List<GameObject>();

    [SerializeField] List<GameObject> weaponList = new List<GameObject>();
//------
    [SerializeField] MonsterKillItem monsterKillItem;
    
    [SerializeField] Damage damage;

    [SerializeField] Move move;

    [SerializeField] SelectButton selectButton;

    [SerializeField] MonsterHp monsterHp; 

    //[SerializeField] RandoImage 
//----   
    [SerializeField] string itemName;

    private void Update() 
    {
        // if(MonsterHp.monsteCount != 0 && MonsterHp.monsteCount %100 == 0)
        // {
        //     //Debug.LogWarning("dasdasda");
        //     SplitItems();
        // }

        if(selectButton.SelectBool2 == true)
        {
            itemName =  monsterKillItem.newnewItmename;
            //Debug.Log("dhqjdnjl");
            SplitItems();
            selectButton.SelectBool2 = false;  
        }        
    }

    private GameObject gameObject2;
    private bool WeaponCheck() //무기 인지 아이템인지 확인 
    {
        for(int i = 0; i < weaponList.Count; i++)
        {
            if (itemName == weaponList[i].name)
            {
                gameObject2 = weaponList[i];
                return true;
            }  
        }   
        return  false; 

    }

    private void PotionType()
    {
        //Debug.Log("PotionType 작동 ");
        if(itemName == "HpPotion")
        {
            Debug.Log("hp 포션 먹음");
            damage.CurrentHealth = damage.CurrentHealth + 20 ;
        }
        else if(itemName == "SpeedPotion")
        {
            Debug.Log("speed 포션 먹음");
            move.Speed = move.Speed + 1 ;  
        }
    }
    private void SplitItems()
    {
        //Debug.Log("SplitItems 작동 ");
        if(WeaponCheck()  == true)
        {
            if (gameObject2.activeSelf == true)
            {
                Debug.Log("무기 강화");

                monsterHp.Damages = monsterHp.Damages + 5;

                Debug.Log(gameObject2.name + "데미지 :" + monsterHp.Damages);
                //gameObject2.SetActive(true);
            }
            else if (gameObject2.activeSelf == false)
            {
                //아이템이 비활성화 되어 있다면 활성화
                gameObject2.SetActive(true);
            }
        }
        else
        {
            PotionType();
        }
    }
}
