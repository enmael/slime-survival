/*
# ----------------------------------------------------------------------------------------
#파일이름 :Damage.cs
#작성자 : 장승배
#생성일 : 2024.09.05
#내용 : 충돌이 발생했을때 슬아더로 만든 체력바가 감소 하는 코드  
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#region 원본 코드 
 // 체력 관련 변수
    // public Slider healthSlider;  // 체력 슬라이더 참조
    // public float maxHealth = 100f;
    // private float currentHealth;

    // void Start()
    // {
    //     currentHealth = maxHealth; // 최대 체력으로 시작
    //     UpdateHealthBar();         // 초기 체력바 설정
    // }

    // // 체력 감소 메서드
    // public void TakeDamage(float damage)
    // {
    //     currentHealth -= damage;
    //     if (currentHealth < 0) currentHealth = 0; // 체력 0 이하로 떨어지지 않게 처리
    //     UpdateHealthBar();                        // 체력바 업데이트
    // }

    // // 체력바를 업데이트하는 메서드
    // void UpdateHealthBar()
    // {
    //     healthSlider.value = currentHealth / maxHealth;
    // }

    // // 2D 충돌 감지 (2D 게임일 경우)
    // void OnCollisionEnter2D(Collision2D col)
    // {
    //     // 적과 충돌 시 체력 감소 (태그가 "Enemy"일 경우)
    //     if (col.gameObject.CompareTag("Enemy"))
    //     {
    //         TakeDamage(10f); // 충돌 시 10만큼 체력 감소
    //     }
    // }

    // // 3D 충돌 감지 (3D 게임일 경우)
    // void OnCollisionEnter(Collision col)
    // {
    //     // 적과 충돌 시 체력 감소 (태그가 "Enemy"일 경우)
    //     if (col.gameObject.CompareTag("Enemy"))
    //     {
    //         TakeDamage(10f); // 충돌 시 10만큼 체력 감소
    //     }
    // }
#endregion
public class Damage : MonoBehaviour
{
    // 무적 타임 관련 변수
    [SerializeField] int eligibleTime;
    // private bool count  = false;
    private float timeElapsed = 0;

    // 체력바 관련 변수 
    public Slider healthSlider;      
    public float maxHealth = 100f; 
    private float currentHealth;

    public float CurrentHealth
    {
        get { return currentHealth; }
        set { currentHealth = value; }
    }


    void Start()
    {
        currentHealth = maxHealth; 
        UpdateHealthBar();         
    }

    private void Update()
    {
        UpdateHealthBar();
    }

    //0 밑으로 체력이 떨어지 않게하는 함수 
    public void TakeDamage(float damage) 
    {
        currentHealth -= damage;
        if (currentHealth < 0) currentHealth = 0;
        UpdateHealthBar();                        
    }
    // 체력바를 업데이트 하는 함수 
    void UpdateHealthBar()
    {
        healthSlider.value = currentHealth / maxHealth;
    }

    // 충돌이 발생 하면 체력을 10 깍아 버리는 함수 
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Monster") )
        {
            TakeDamage(5f);
        }
    }    
}
