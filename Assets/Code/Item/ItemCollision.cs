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
