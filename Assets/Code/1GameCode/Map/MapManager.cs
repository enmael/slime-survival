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

public class MapManager : MonoBehaviour
{
    [SerializeField]List<GameObject>list;

    [SerializeField]Move move;
    void Start()
    {
        list.Capacity = 20;
    }

    private void Update()
    {
        //Debug.Log("x :" + move.Movement.x);

        if (list != null && list.Count > 0)
        {
            //right(1) left(-1)
            Vector2 vectorRight = new Vector2(55, 0);
            Vector2 vectorLeft = new Vector2(-55, 0);

            if (move.Movement.x > 0)
            {
                Vector2 listA = list[0].transform.position;
                listA = listA + vectorRight;
                list[0].transform.position = listA;
                //list[0].gameObject.SetActive(true);
                list.RemoveAt(0);

            }
            else if (move.Movement.x < 0)
            {
                Vector2 listA = list[0].transform.position;
                listA = listA + vectorLeft;
                list[0].transform.position = listA;
                //list[0].gameObject.SetActive(true);
                list.RemoveAt(0);
            }
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        GameObject gameObject = other.gameObject;
        if (other.CompareTag("Map"))
        {
            //gameObject.SetActive(false);
            list.Add(gameObject);
        }
    }
    //private void Update() 
    //{

    //    if (list != null && list.Count > 0)
    //    {
    //        Vector2 vectorRight = new Vector2(55, 0);
    //        Vector2 vectorLeft = new Vector2(-55, 0);

    //        // 첫 번째 오브젝트 위치를 직접 업데이트
    //        if(move.Movement.x > 0)
    //        {   
    //            list[0].transform.position += (Vector3)vectorRight; // 위치 업데이트
    //            list.RemoveAt(0);
    //        }
    //        else if(move.Movement.x < 0)
    //        {
    //            list[0].transform.position += (Vector3)vectorLeft; // 위치 업데이트
    //            list.RemoveAt(0);
    //        }
    //    }
    //}

//    private void OnTriggerExit2D(Collider2D other)
//{
//    if (other.CompareTag("Map"))
//    {
//        list.Add(other.gameObject);
//    }
//}


  
}
