/*
# ----------------------------------------------------------------------------------------
#파일이름 : ItemManager2.cs
#작성자 : 장승배
#생성일 : 2024.11.08
#내용 :  처음 게임을 시작하면 사용할 무기를 할당하는 코드이다 이름은 나중에 바꿀거다.
- 한번만 사용하자 두번은 사용하지 말자 
# ------------------------------------------------------------------------------------------
*/


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager2 : MonoBehaviour
{
   
    [SerializeField] List<GameObject> weaponList = new List<GameObject>(); 

    [SerializeField] string startWeaponName;

    [SerializeField] SelectButton selectButton;

    [SerializeField] GameObject canvasOject;

    private int randomIndex; 

    private bool startWeaponBool = true;   

    public  String StartWeaponName
    {
        get { return startWeaponName; } 
    }
    private void Awake() 
    {
        weaponList.Capacity = 10;

    }  

    private void Start() 
    {
        StartWeapon();
    }

    private void Update() 
    {
        weaponList[randomIndex].SetActive(selectButton.SelectBool);
    }

    private void StartWeapon()
    {
        randomIndex = UnityEngine.Random.Range(0, weaponList.Count);
       
        Debug.Log("무기 할당:" + weaponList[randomIndex].name);
        
        startWeaponName = weaponList[randomIndex].name; 
        Time.timeScale = 0f;
        canvasOject.SetActive(true);
        
    }
}
