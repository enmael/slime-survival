using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager2 : MonoBehaviour
{
    //[SerializeField] List<GameObject> itemList = new List<GameObject>();
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
        //itemList.Capacity = 10;
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
