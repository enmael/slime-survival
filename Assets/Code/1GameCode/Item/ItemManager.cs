/*
# ----------------------------------------------------------------------------------------
#파일이름 :ItemManager.cs
#작성자 : 장승배
#생성일 : 2024.10.28
#내용 : 아이템을 먹었을때 나오는 효과가 실행되는 코드 
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] int maxSpeed;

    private bool Hpitem = false;
    private bool speeditem = false;

    private Move move;
    private Damage damage;
    

    public bool HpItem
    {
        get { return Hpitem; }
        set { Hpitem = value; }
    }

    public bool SpeedItem
    {
        get { return speeditem; }
        set { speeditem = value; }
    }



    private void Start()
    {
        move = FindObjectOfType<Move>();
        damage = FindObjectOfType<Damage>();
      
    }

    private void Update()
    {
        if(Hpitem == true)
        {
            damage.CurrentHealth = damage.CurrentHealth + 20;
            Hpitem = false;
           
        }

        if (speeditem == true)
        {
            move.Speed = move.Speed + 5f;
            speeditem = false;  
            
        }
    }






}
