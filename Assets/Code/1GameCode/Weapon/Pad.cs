using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
//   [SerializeField] Transform player;

//   private bool boolPad = true;

//   private void Update() 
//   {
//      if ( boolPad == true)
//     {
//         float moveX = Input.GetAxis("Horizontal");
//         float moveXCopy = moveX;

//         if ( moveXCopy > 0 ) 
//         {

//         }   
//         else
//         {

//         }
//     }
//  }   
    [SerializeField]public Transform player;  // 플레이어의 Transform을 드래그해서 할당

    void Update()
    {
        // 플레이어가 있는 방향으로 오브젝트가 회전하도록 설정
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // 각도를 라디안에서 도로 변환
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
