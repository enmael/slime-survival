/*
# ----------------------------------------------------------------------------------------
#�����̸� : ItemManager3.cs 
#�ۼ��� : ��¹�
#������ : 2024.11.11
#���� : ó�� ����� ���⸦ �����ϰ� ���͸� 100���� ���̸�, ����Ǵ� ȸ�� �������� �÷��̾ �����ϴ� �ڵ��̴�.
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
    private void StartWeapon() // ���� ���� ���� �Ҵ�
    {
        Time.timeScale = 0f;
        canvasOject.SetActive(true);
        int randomIndex = UnityEngine.Random.Range(0, weaponlist.Count);
        itemName = weaponlist[randomIndex].name;  
        Debug.Log(weaponlist[randomIndex].name + "���� �Ҵ�");
        weaponlist[randomIndex].SetActive(true);
    }

    private void MonsterCount() //100ų ����
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
    private void RandomItem() // �����ϰ� �����ϱ� 
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

    private bool Itemclassification() //�Һ� �������� ���� ���⸦ ���� ���� 
    {
        int listSelect = 0;
        listSelect = UnityEngine.Random.Range(0, 2);
        
        if (listSelect == 0)
        {
            //����
            return true;
        }

        //�Һ�
        return false;
        
    }

    private void NewWeapon(int number) //���� Ȱ��ȭ ���ο� ���� ��ȭ ���� ���� �Ҵ����� ���ϴ� �Լ�
    {
        itemName = weaponlist[number].name;

        if (weaponlist[number].activeSelf == true)
        {
            //���� ��ȭ
            Debug.Log(weaponlist[number] + "��ȭ");
        }
        else
        {
            Debug.Log(weaponlist[number] + "�ű� ����");
            //���� Ȱ��ȭ
            weaponlist[number].SetActive(true); 
        }
    }

    private void NewPotion(int number)
    {
        itemName = potion[number].name;

        if (potion[number].name == "HpPotion")
        {
            Debug.Log("Hp ���� ����");
            //���⿡ ���� ���� ȿ�� �� ������ ��
        }
        if(potion[number].name == "SpeedPotion")
        {
            Debug.Log("speed ���� ����");
            //���⿡ ���� ���� ȿ�� �� ������ ��
        }
    }
}
