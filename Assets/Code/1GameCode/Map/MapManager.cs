/*
# ----------------------------------------------------------------------------------------
#파일이름 :MapManager.cs
#작성자 : 장승배
#생성일 : 2024.10.31
#내용 : 무한맵 생성 코드 
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[RequireComponent(typeof(Move))]
public class MapManager : MonoBehaviour
{
    [SerializeField]List<GameObject>list;
    // //--- 추가---
    // [SerializeField]int[] blockNumber = { 8, 3, -2, -7, -12 };
    // [SerializeField]List<GameObject>objectsList;
    // // ---
    Move move;
    void Start()
    {
        
        move = GetComponent<Move>();
        list.Capacity = 20;
        // //추가--
        // objectsList.Capacity = 20; 
        // //--
    }

 private void Update() 
    {
        Debug.Log("x :" + move.Movement.x);
    
        if (list != null && list.Count > 0)
        {
            //right(1) left(-1)
            Vector2 vectorRight = new Vector2(55,0);
            Vector2 vectorLeft= new Vector2(-55,0);

            if(move.Movement.x  > 0)
            {   
                Vector2 listA =list[0].transform.position;
                listA = listA +  vectorRight;
                list[0].transform.position = listA;
                //list[0].gameObject.SetActive(true);
                list.RemoveAt(0);
                 
            }
            else if(move.Movement.x <0)
            {
                 Vector2 listA =list[0].transform.position;
                listA = listA +  vectorLeft;
                list[0].transform.position = listA;
                //list[0].gameObject.SetActive(true);
                list.RemoveAt(0);
            }
        }   
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        GameObject gameObject= other.gameObject;
        if (other.CompareTag("Map"))
        {
            //gameObject.SetActive(false);
            list.Add(gameObject);
        }
    }

    // private void RandomObject()
    // {
    //     //1. 생성할 블록을 갯수를 정한다.
    //     int number = UnityEngine.Random.Range(1,4);
        
    //     for(int i = 0; i < number; i++)
    //     {
    //         int bloc = UnityEngine.Random.Range(0,5);

    //     } 
    //     //int bloc = UnityEngine.Random.Range(0,5);

    // }
}
