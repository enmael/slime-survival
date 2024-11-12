///*
//# ----------------------------------------------------------------------------------------
//#파일이름 :PlayeCrash.cs
//#작성자 : 장승배
//#생성일 : 2024.09.04
//#내용 : 충돌이 발생했을때 캐릭터가 밀리는는 코드 
//-- 지금은 사용하지 않는 코드이다 (2024.11.08)
//# ------------------------------------------------------------------------------------------
//*/
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayeCrash : MonoBehaviour
//{
//#region 원본 코드

//#region 충돌이 발생 했을때 호출 
//// void OnCollisionEnter2D(Collision2D collision)
//// {
////     Debug.Log(collision.gameObject.name + "몬스터와 부디침");
//// }

//#endregion

//#region 충돌이 발생했을때 충돌 지점 표시 
//// void OnCollisionEnter2D(Collision2D col)
//// {
////     ContactPoint2D contact = col.contacts[0];
////     Vector2 pos = contact.point;
////     Vector2 normal = contact.normal;
////     Debug.Log("충돌 지점: " + pos);
////     Debug.Log("법선 벡터: " + normal);
//// }

//#endregion

//#region 수정전

//// [SerializeField] int eligibleTime; // 무적 타임 
////  public Transform playerTransform ; // 플레이어의 현재 좌표값 가져옴
//// private float timeElapsed = 0; // 시간 
//// private bool count = true;
//// void OnCollisionEnter2D(Collision2D col)
//// {

////     if(count == true)
////     {
////         Vector2 playerPosition = playerTransform.position;

////         ContactPoint2D contact = col.contacts[0];

////         Vector2 pos = contact.point;

////         float playPosX = pos.x +2f;
////         float playPosy = pos.y +2f;  


////         playerTransform.position = new Vector2(playPosX, playPosy);

////         count = false;
////     }

//// }

//// private void Update() 
//// {
////     if(count == false)
////     {
////         timeElapsed += Time.deltaTime;
////         if(timeElapsed > eligibleTime)
////         {
////             count = true;
////             timeElapsed = 0f;
////         }
////     }
    
//// }
//#endregion
//#endregion

//[SerializeField] int eligibleTime; // 무적 타임 
// public Transform playerTransform ; // 플레이어의 현재 좌표값 가져옴
//private float timeElapsed = 0; // 시간 
//private bool count = true;


//void OnCollisionEnter2D(Collision2D col)
//{
//    BounceOff(col);
//}

//void BounceOff(Collision2D col)
//{
//    if(count == true)
//    {
//        Vector2 playerPosition = playerTransform.position;

//        ContactPoint2D contact = col.contacts[0];

//        Vector2 pos = contact.point;

//        float playPosX = pos.x +2f;
//        float playPosy = pos.y +2f;  


//        playerTransform.position = new Vector2(playPosX, playPosy);

//        count = false;
//    }
//}

//private void Update() 
//{
//    if(count == false)
//    {
//        timeElapsed += Time.deltaTime;
//        if(timeElapsed > eligibleTime)
//        {
//            count = true;
//            timeElapsed = 0f;
//        }
//    }
    
//}


//}
