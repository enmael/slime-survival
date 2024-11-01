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

    // public Vector2 inputV2;
    // [SerializeField]public float speed = 10.0f ;
    // [SerializeField] public float speedMax = 20.0f;

   
    // Rigidbody2D rigidbody2D;
    // SpriteRenderer spriteRenderer;

    // public float Speed
    // {
    //     get { return speed; }
    //     set { speed = value; }
    // }

    // void Awake() 
    // {
    //     rigidbody2D = GetComponent<Rigidbody2D>();       
    //     spriteRenderer = GetComponent<SpriteRenderer>();
    // }
  

    // void FixedUpdate()
    // {
        
    //         // 이동 벡터를 계산
    //         Vector2 moveVector = inputV2 * speed * Time.fixedDeltaTime;
    //         // 물리적 이동
    //         rigidbody2D.MovePosition(rigidbody2D.position + moveVector);


    // }

    // void OnMove(InputValue value)
    // {
    //     inputV2 = value.Get<Vector2>();    
    // }

    // void LateUpdate() 
    // {
    //     if(inputV2.x != 0)
    //     {
    //         // 스프라이트 방향 전환
    //         spriteRenderer.flipX = inputV2.x < 0;
    //     }   
    // }

       public float speed = 5f;  // 이동 속도
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer spriteRenderer;  // 스프라이트 렌더러

    private Vector2 movement;

    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public Vector2 Movement
    {
        get { return movement; }
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();  // SpriteRenderer 컴포넌트 가져오기
    }

    private void Update()
    {
        // 입력 받기 (WASD 또는 화살표 키)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    private void LateUpdate()
    {
        // 이동 방향에 따른 스프라이트 반전
        if (movement.x != 0)
        {
            spriteRenderer.flipX = movement.x < 0;
        }
    }
}
