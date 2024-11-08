/*
# ----------------------------------------------------------------------------------------
#파일이름 :ItemSpawn.cs
#작성자 : 장승배
#생성일 : 2024.10.28
#내용 :아이템을 먹으면 효과를 주는 코드 
- 이제 사용하지 않는 코드이다(2024.11.08)
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollision : MonoBehaviour
{

    [SerializeField] public GameObject[] item;
    
    private Move move;
    private Damage damage;
    
    private ItemSpawn itemSpawn;


    private void Start()
    {
        move = FindObjectOfType<Move>();
        damage = FindObjectOfType<Damage>();
        itemSpawn = FindObjectOfType<ItemSpawn>();
        

        item = itemSpawn.ItemList; 
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        for (int i = 0; i < item.Length; i++)
        {
            if (other.gameObject.name == item[i].name)
            {
                ItemFunction(other.gameObject);
            }
        }

    }

    private void ItemFunction(GameObject gameObject)
    {
        if (gameObject.name == "HpItem")
        {
            
            damage.CurrentHealth = damage.CurrentHealth + 20f;

            gameObject.SetActive(false);

        }

        if (gameObject.name == "SpeedItem")
        {
            move.Speed = move.Speed + 5f;
           


            gameObject.SetActive(false);
        }

    }
}
