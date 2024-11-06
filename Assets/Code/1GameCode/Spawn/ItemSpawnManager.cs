using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   
public class ItemSpawnManager : MonoBehaviour
{

    [SerializeField] GameObject[]ItemArray;
    [SerializeField] Image image;
    private void Update()
    {
        if(MonsterHp.monsteCount != 0 && MonsterHp.monsteCount % 100 == 0)
        {
            Time.timeScale = 0f;
            image.enabled = true;
            //ItimeRandom(vector2)
        }
        //MonsterHp.monsteCount    
    }

    // private void ItimeRandom(Vector2 vector2)
    // {
    //     int randomIndex = UnityEngine.Random.Range(0, ItemArray.Length);
    //     GameObject gameObject = Instantiate(ItemArray[randomIndex], vector2, Quaternion.identity);  
        
    // }
}