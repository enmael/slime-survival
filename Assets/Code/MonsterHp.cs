/*
# ----------------------------------------------------------------------------------------
#파일이름 :MonsterHp.cs
#작성자 : 장승배
#생성일 : 2024.09.05
#내용 : 몬스터가 특정 태그(player)랑 붙이치면 데미지 를 입는 코드  
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


#region  원본 코드

// // 몬스터 체력 관련 변수
//     public float monsterMaxHealth = 50f;  // 몬스터의 최대 체력
//     private float monsterCurrentHealth;

//     // 플레이어 공격 데미지
//     public float attackDamage = 10f;  // 플레이어가 주는 데미지

//     void Start()
//     {
//         // 몬스터 체력을 최대 체력으로 설정
//         monsterCurrentHealth = monsterMaxHealth;
//     }

//     // 몬스터가 데미지를 받는 메서드
//     public void TakeDamage(float damage)
//     {
//         monsterCurrentHealth -= damage;  // 몬스터 체력 감소
//         if (monsterCurrentHealth <= 0)
//         {
//             Die();  // 체력이 0 이하일 경우 몬스터를 죽음 처리
//         }
//     }

//     // 몬스터가 죽었을 때 처리
//     void Die()
//     {
//         Debug.Log("Monster is dead!");
//         Destroy(gameObject);  // 몬스터 오브젝트를 파괴
//     }

//     // 2D 충돌 감지 (2D 게임일 경우)
//     void OnCollisionEnter2D(Collision2D col)
//     {
//         // 몬스터와 플레이어가 충돌했을 때
//         if (col.gameObject.CompareTag("Monster"))
//         {
//             // 몬스터에게 데미지를 입힘
//             PlayerMonsterInteraction monster = col.gameObject.GetComponent<PlayerMonsterInteraction>();
//             if (monster != null)
//             {
//                 monster.TakeDamage(attackDamage);  // 공격 데미지 전달
//             }
//         }
//     }

//     // 3D 충돌 감지 (3D 게임일 경우)
//     void OnCollisionEnter(Collision col)
//     {
//         // 몬스터와 플레이어가 충돌했을 때
//         if (col.gameObject.CompareTag("Monster"))
//         {
//             // 몬스터에게 데미지를 입힘
//             PlayerMonsterInteraction monster = col.gameObject.GetComponent<PlayerMonsterInteraction>();
//             if (monster != null)
//             {
//                 monster.TakeDamage(attackDamage);  // 공격 데미지 전달
//             }
//         }
//     }
#endregion
public class MonsterHp : MonoBehaviour
{
    public float monsterHpMax = 10f; // 몬스터의 최대 체력 
    public float monsterHp; //현재 몬스터의 체력 

    static public int monsteCount = 0;
    
    void Start()
    {
        monsterHp = monsterHpMax;
    }


    public void TakeDamage(float damage)
    {
        monsterHp -= damage;  // 몬스터 체력 감소
        if (monsterHp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
   
        Destroy(gameObject);
        monsteCount++;

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.CompareTag("playe"))
        {
            TakeDamage(5f);
        }
    }
}
