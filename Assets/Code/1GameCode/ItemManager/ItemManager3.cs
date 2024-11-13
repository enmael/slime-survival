/*
# ----------------------------------------------------------------------------------------
#파일이름 : ItemManager3.cs 
#작성자 : 장승배
#생성일 : 2024.11.11
#내용 : 처음 사용할 무기를 지급하고 몬스터를 100정도 죽이면, 무기또는 회복 아이템을 플레이어에 지금하는 코드이다.
# ------------------------------------------------------------------------------------------
*/
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.Tilemaps;
using UnityEngine;

public class ItemManager3 : MonoBehaviour
{
    [SerializeField] List<GameObject>weaponlist = new List<GameObject>();
    [SerializeField] List <GameObject> potion = new List<GameObject>();
    [SerializeField] bool oneBool = true;
    [SerializeField] GameObject canvasOject;
    [SerializeField] string itemName;
   

    public string ItemName
    {
        get { return itemName; }
        //set { itemName = value; }
    }
    public bool OneBool
    {
        get { return oneBool; }
        set { oneBool = value; }
    }
    private void Awake()
    {
        weaponlist.Capacity = 10;
        potion.Capacity = 10;
    }

    private void Start()
    {
        StartWeapon();
    }

    private void Update()
    {
        MonsterCount();
    }
    private void StartWeapon() // 게임 시작 무기 할당
    {
        Time.timeScale = 0f;
        canvasOject.SetActive(true);
        int randomIndex = UnityEngine.Random.Range(0, weaponlist.Count);
        itemName = weaponlist[randomIndex].name;  
        Debug.Log(weaponlist[randomIndex].name + "무기 할당");
        weaponlist[randomIndex].SetActive(true);
    }

    private void MonsterCount() //100킬 측정
    {
        
        if(oneBool == true)
        {
            if (MonsterHp.monsteCount != 0 && MonsterHp.monsteCount % 100 == 0)
            {
                RandomItem();
                Time.timeScale = 0f;
                canvasOject.SetActive(true);
                oneBool = false;

            }
        }
        
    }
    private void RandomItem() // 랜덤하게 지급하기 
    {
        int randomIndex;
        if (Itemclassification() == true)
        {
            randomIndex = UnityEngine.Random.Range(0, weaponlist.Count);
            NewWeapon(randomIndex);
        }
        else
        {
            randomIndex = UnityEngine.Random.Range(0, potion.Count);
            NewPotion(randomIndex);
        }
    }

    private bool Itemclassification() //소비 아이템을 줄지 무기를 줄지 지정 
    {
        int listSelect = 0;
        listSelect = UnityEngine.Random.Range(0, 2);
        
        if (listSelect == 0)
        {
            //무기
            return true;
        }

        //소비
        return false;
        
    }

    private void NewWeapon(int number) //무기 활성화 여부에 따라 강화 할지 새로 할당할지 정하는 함수
    {
        itemName = weaponlist[number].name;

        if (weaponlist[number].activeSelf == true)
        {
            //무기 강화
            Debug.Log(weaponlist[number] + "강화");
        }
        else
        {
            Debug.Log(weaponlist[number] + "신규 보급");
            //무기 활성화
            weaponlist[number].SetActive(true); 
        }
    }

    private void NewPotion(int number)
    {
        itemName = potion[number].name;

        if (potion[number].name == "HpPotion")
        {
            Debug.Log("Hp 포션 먹음");
            //여기에 이제 포션 효과 만 넣으면 끝
        }
        if(potion[number].name == "SpeedPotion")
        {
            Debug.Log("speed 포션 먹음");
            //여기에 이제 포션 효과 만 넣으면 끝
        }
    }
}
