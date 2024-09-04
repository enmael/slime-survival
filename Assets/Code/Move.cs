/*
# ----------------------------------------------------------------------------------------
#파일이름 :Move.cs
#작성자 : 장승배
#생성일 : 2024.09.02
#내용 : 플레이어 캐릭터의 움직임을 구현 
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Move : MonoBehaviour
{
    #region 원본 코드
//  public Vector2 inputV2;

//    public float spped;

//     Rigidbody2D rigidbody2D;
//     SpriteRenderer spriteRenderer;
//    void Awake() 
//    {
//         rigidbody2D = GetComponent<Rigidbody2D>();       
//         spriteRenderer = GetComponent<SpriteRenderer>();
//    }

//     // void Update()
//     // {
//     //     inputV2.x = Input.GetAxisRaw("Horizontal");
//     //     inputV2.y = Input.GetAxisRaw ("Vertical");
//     // }

//     void FixedUpdate()
//     {
//         // rigidbody2D.AddForce(inputV2);
//         // rigidbody2D.velocity =inputV2;
//         //Vector2 newVector2 =inputV2.normalized * spped * Time.fixedDeltaTime;
//         Vector2 newVector2 =inputV2 * spped * Time.fixedDeltaTime;


//         rigidbody2D.MovePosition(rigidbody2D.position+ newVector2); 
//     }

//     void OnMove(InputValue value)
//     {
//         inputV2 = value.Get<Vector2>();    
//     }

//     void LateUpdate() 
//     {
//         if(inputV2.x != 0)
//         {
//             spriteRenderer.flipX = inputV2.x < 0;
//         }   
//     }

    #endregion

    public Vector2 inputV2;
    public float speed = 3.0f ;

    Rigidbody2D rigidbody2D;
    SpriteRenderer spriteRenderer;

    void Awake() 
    {
        rigidbody2D = GetComponent<Rigidbody2D>();       
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        // 이동 벡터를 계산
        Vector2 moveVector = inputV2 * speed * Time.fixedDeltaTime;
        // 물리적 이동
        rigidbody2D.MovePosition(rigidbody2D.position + moveVector);
    }

    void OnMove(InputValue value)
    {
        inputV2 = value.Get<Vector2>();    
    }

    void LateUpdate() 
    {
        if(inputV2.x != 0)
        {
            // 스프라이트 방향 전환
            spriteRenderer.flipX = inputV2.x < 0;
        }   
    }
}
