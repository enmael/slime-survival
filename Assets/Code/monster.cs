/*
# ----------------------------------------------------------------------------------------
#파일이름 :Move.cs
#작성자 : 장승배
#생성일 : 2024.09.01
#내용 : 몬스터가 플레이어 캐릭터를 추적하도록 만든 코드 
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
#region  원본 코드
// public float speed = 1.5f;
    // public Rigidbody2D target;

    // bool isLive = true;

    // Rigidbody2D rigid;
    // SpriteRenderer sprite;

    //  private void Awake() 
    //  {
    //     rigid = GetComponent<Rigidbody2D>();
    //     sprite = GetComponent<SpriteRenderer>();
    // }
    // private void FixedUpdate() 
    // {
    //     if (!isLive)
    //     {
    //         return;

    //     }
    //     // Vector2 dirVec = target.position - rigid.velocity;
    //     // Vector2 nexVec = dirVec.normalized * speed * Time.fixedDeltaTime;
    //     // rigid.MovePosition(rigid.position+nexVec);
    //     // rigid.velocity = Vector2.zero;


    //     Vector2 dirVec = target.position - rigid.position;
    //     Vector2 nexVec = dirVec.normalized * speed * Time.fixedDeltaTime;
    //     rigid.MovePosition(rigid.position + nexVec);

    // }

    // private void LateUpdate() {
    //     sprite.flipX = target.position.x < rigid.position.x;
    // }

    // private void OnEnable() {
    //     //자기 스스로 타겟을 스스로 인식한다.
    //     target = gamemanager.instance.move.GetComponent<Rigidbody2D>();
    // }

#endregion
    
#region 수정된 코드
    public float speed = 1.5f; // 몬스터의 이동 속도
    public Rigidbody2D target; // 추적할 대상

    private bool isLive = true; // 몬스터가 살아있는지 여부

    private Rigidbody2D rigid; // 몬스터의 Rigidbody2D 컴포넌트
    private SpriteRenderer sprite; // 몬스터의 SpriteRenderer 컴포넌트

    private void Awake()
    {
        // 컴포넌트 초기화
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        if (!isLive || target == null)
            return;

        // 플레이어 위치로 향하는 방향 벡터 계산
        Vector2 dirVec = target.position - rigid.position;
        Vector2 nexVec = dirVec.normalized * speed * Time.fixedDeltaTime;

        // 새로운 위치로 몬스터 이동
        rigid.MovePosition(rigid.position + nexVec);
    }

    private void LateUpdate()
    {
        if (target == null)
            return;

        // 몬스터가 플레이어를 바라보도록 좌우 방향 전환
        sprite.flipX = target.position.x < rigid.position.x;
    }

    private void OnEnable()
    {
        // GameManager에서 플레이어의 Rigidbody2D를 가져와서 타겟으로 설정
        if (gamemanager.instance != null)
        {
            if (gamemanager.instance.move != null)
            {
                target = gamemanager.instance.move.GetComponent<Rigidbody2D>();
            }
            else
            {
                Debug.LogError("GameManager.instance.move is not assigned.");
            }
        }
        // else
        // {
        //     Debug.LogError("GameManager.instance is not assigned.");
        // }
    }

    #endregion
    
}
