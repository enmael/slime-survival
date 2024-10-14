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
