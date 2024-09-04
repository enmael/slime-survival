/*
# ----------------------------------------------------------------------------------------
#파일이름 :Random.cs
#작성자 : 장승배
#생성일 : 2024.09.03
#내용 : 플레이어의 위치값을 가지고 x 축 20, y 축 20 범위 내에서 랜덤하게 몬스터 소환하는 코드 
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class Random : MonoBehaviour
{
#region 원본 코드

#region 랜덤 생성(유니티)
// [SerializeField] GameObject[] gameObject2 ;
//     public float x; // X축 랜덤 범위
//     public float y; // Y축 랜덤 범위
//     public float z; // Z축 랜덤 범위

   
//     private void Start()
//     {
//         SpawnObject();
//     }

//     void SpawnObject()
//     {
//         for(int i = 0; i < 10; i++) 
//         {
//                 // 랜덤 위치 생성
//                 float xPos = Random.Range(-x, x);
//                 float yPos = Random.Range(-y, y);
//                 float zPos = Random.Range(-z, z);
           
//                 Vector3 randomPosition = new Vector3(xPos, yPos, zPos);

//             if (i >= 0 && i <5)
//             {
//                 Instantiate(gameObject2[i], randomPosition, Quaternion.identity);
//             }
//             else if(i>=5 && i < 10) 
//             {
//                 Instantiate(gameObject2[i-5], randomPosition, Quaternion.identity);
//             }
//         }

//     }
#endregion

#region 3초마다 플레이어 위치 출력

//   void  PlayerPos()
//     {
//         // 경과 시간 누적
//         timeElapsed += Time.deltaTime; 

//         if (timeElapsed > 3f) // 3초가 지났는지 확인
//         {
//             if (playerTransform != null)
//             {
//                 // 플레이어의 현재 위치를 가져옵니다.
//                 Vector2 playerPosition = playerTransform.position;

                
//                  // 플레이어의 위치를 콘솔에 출력합니다.
//                 //Debug.Log("Player Position: " + playerPosition);

//                 // timeElapsed를 0으로 리셋
//                 timeElapsed = 0f;
                
//             }
//         }
 
        
//     }
#endregion

#region  랜덤으로 오브젝트 생성 

// [SerializeField] GameObject gameObject ;
// void SpawnObject()
// {
//     // 유니티에서의 랜덤이 아닌 그냥 c#에서의 랜덤
//     System.Random rand = new System.Random();
//     //float randomInt = rand.Next(0, 10);

//     float xPos =  rand.Next(0, 10);
//     float yPos = rand.Next(0, 10);  

//     Vector2 randomPos = new Vector2(xPos, yPos);   
//     Instantiate(gameObject, randomPos, Quaternion.identity);
// }
#endregion

#region 완성 코드
//   public Transform playerTransform ; // 플레이어의 현재 좌표값 가져옴
//  private float timeElapsed = 0; // 시간 

// [SerializeField] GameObject gameObject ;

// private void Update() 
// {
//     SpawnObject();
// }

// void SpawnObject()
// {
//         timeElapsed += Time.deltaTime; 

//         if (timeElapsed > 3f) // 3초가 지났는지 확인
//         {
//             if (playerTransform != null)
//             {
//                 // 플레이어의 현재 위치를 가져옵니다.
//                 Vector2 playerPosition = playerTransform.position;
                
//                 System.Random rand = new System.Random();

//                 float xPos = rand.Next((int)playerPosition.x - 20, (int)playerPosition.x + 20);// x
//                 float yPos = rand.Next((int)playerPosition.y - 20, (int)playerPosition.y + 20);// y
                
                
//                 Vector2 randomPos = new Vector2(xPos, yPos);


//                 Instantiate(gameObject, randomPos, Quaternion.identity);

//                 // timeElapsed를 0으로 리셋
//                 timeElapsed = 0f;
                
//             }
//         }

// }
#endregion
#endregion



 public Transform playerTransform ; // 플레이어의 현재 좌표값 가져옴
 private float timeElapsed = 0; // 시간 

private int count = 0;  


//오브젝트 불러오기
[SerializeField] GameObject []gameObject ; 
//몬스터의 종류의 갯수
[SerializeField] int typeMonsters;
//몬스터 소환할 갯수 
[SerializeField] int monstersNumber;

// private void Awake() 
// {
//     gameObject = new GameObject[4];
//     // 아니 그냥 c#에서 하던 대로 하니까 내가 할당한 객체를들이 다 날라가고 비어 있는 상태로 나와버리네 이먼 그지 같은 경우가다 있냐
// }

private void Update() 
{
  SpawnObject();

}

void SpawnObject()
{
        timeElapsed += Time.deltaTime; 

        if (timeElapsed > 3f && count < monstersNumber) // 3초가 지났는지 확인, 그리고 지정한 몬스터 수가 맞는지 확인 
        {
            if (playerTransform != null)
            {
                // 플레이어의 현재 위치를 가져옵니다.
                Vector2 playerPosition = playerTransform.position;
                
                System.Random rand = new System.Random();

                float xPos = rand.Next((int)playerPosition.x - 20, (int)playerPosition.x + 20);
                float yPos = rand.Next((int)playerPosition.y - 20, (int)playerPosition.y + 20);
                
                int rannum = rand.Next(0,typeMonsters-1); 
                
                Vector2 randomPos = new Vector2(xPos, yPos);


                Instantiate(gameObject[rannum], randomPos, Quaternion.identity);

                // timeElapsed를 0으로 리셋
                timeElapsed = 0f;
                count++;
                
            }
        }

}
}
