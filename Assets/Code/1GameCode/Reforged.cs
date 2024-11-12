
//폐기
// /*
// # ----------------------------------------------------------------------------------------
// #파일이름 :Reforged.cs
// #작성자 : 장승배
// #생성일 : 2024.09.02
// #내용 : 플레이어의 위치에 방향에 따라서 이전에 만든 가로 40 세로 40의 맵을 재 사용하여 앞으로 이동시키 코드 
// # ------------------------------------------------------------------------------------------
// */
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Reforged : MonoBehaviour
//  {
//     #region 원본 코드  
//     // private void OnTriggerExit2D(Collider2D other) 
//     // {
//     //     // 트리거 체크된 콜라이더 밖으로 나가면 이벤트 발생 
//     //  if(! other.CompareTag("Area"))
//     //  {
//     //     return;
//     //     //Area 태그가 아니면 실행x
//     //  }
//     //     Vector3 playPos = gamemanager.instance.move.transform.position;
//     //     Vector3 myPos = transform.position; 

//     //     float diffx =Mathf.Abs(playPos.x - myPos.x); 
//     //     float diffy =Mathf.Abs(playPos.y - myPos.y); 

//     //     Vector3 playerir =gamemanager.instance.move.transform.position;

//     //     float dirx = playerir.x < 0 ? -1: 1;
//     //     float diry = playerir.y < 0 ? -1: 1; 

//     //     switch(transform.tag)
//     //     {
//     //         case "Ground" :
//     //         if (diffx > diffy)
//     //         {
//     //             transform.Translate(Vector3.right* dirx * 40);
//     //         }
//     //         else if (diffx < diffy)
//     //         {
//     //             transform.Translate(Vector3.up * diry * 40);
//     //         } 
//     //         break;

//     //         case "Enemy" :
//     //         break;

//     //     }

//     // }
//     #endregion
    
//     #region  수정된 코드 
//     [SerializeField]public float tileWidth = 120f; // 타일의 가로 크기
//     [SerializeField] public float tileHeight = 120f; // 타일의 세로 크기

//     private void OnTriggerExit2D(Collider2D other) 
//     {
//         // 트리거 체크된 콜라이더 밖으로 나가면 이벤트 발생 
//         if (!other.CompareTag("Area"))
//         {
//             return;
//             // Area 태그가 아니면 실행 x
//         }

//         // 플레이어의 위치와 타일의 위치를 가져옴
//         Vector3 playerPos = gamemanager.instance.move.transform.position;
//         Vector3 myPos = transform.position;

//         float diffx = Mathf.Abs(playerPos.x - myPos.x); 
//         float diffy = Mathf.Abs(playerPos.y - myPos.y); 

//         // 타일 이동 방향 결정
//         if (diffx > diffy)
//         {
//             // 플레이어가 타일의 x 축과 더 가까운 경우
//             transform.position = new Vector3(myPos.x + Mathf.Sign(playerPos.x - myPos.x) * tileWidth, myPos.y, myPos.z);
//         }
//         else if (diffx < diffy)
//         {
//             // 플레이어가 타일의 y 축과 더 가까운 경우
//             transform.position = new Vector3(myPos.x, myPos.y + Mathf.Sign(playerPos.y - myPos.y) * tileHeight, myPos.z);
//         }
//     }
    
//     #endregion
    

// }
