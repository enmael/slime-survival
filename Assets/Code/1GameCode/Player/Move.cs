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
        //이거 좀더 알아먹게 바꿔라 
        if (movement.x != 0)
        {
            spriteRenderer.flipX = movement.x < 0;
        }
    }
}
