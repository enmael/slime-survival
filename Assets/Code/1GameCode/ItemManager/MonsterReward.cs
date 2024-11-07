using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterReward : MonoBehaviour
{
   [SerializeField] List<GameObject> itemList = new List<GameObject>(); 
   [SerializeField] GameObject canvasOject;
   //[SerializeField] string itemName;

    private int randomIndex;
    //MonsterHp.monsteCount
    private void Awake() 
    {
        itemList.Capacity = 10;
    } 

    private void Update() 
    {
        if(MonsterHp.monsteCount != 0  && MonsterHp.monsteCount % 100 == 0)
        {
            randomIndex = UnityEngine.Random.Range(0, itemList.Count);
            
            Debug.Log("아이템 지급:"+ itemList[randomIndex].name);
            
                        
            Time.timeScale = 0f;
            canvasOject.SetActive(true);


        }
    }
}
