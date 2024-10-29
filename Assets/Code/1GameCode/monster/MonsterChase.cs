/*
# ----------------------------------------------------------------------------------------
#파일이름 :MonsterChase.cs
#작성자 : 장승배
#생성일 : 2024.10.28
#내용 : 몬스터가 플레이어의 위치를 추적하는하면서 움직이는 코드 
# ------------------------------------------------------------------------------------------
*/

using UnityEngine;
public class MonsterChase : MonoBehaviour
{
    [SerializeField] Transform playerTransform; // 플레이어의 Transform
    [SerializeField] float speed = 2.0f; // 몬스터의 이동 속도
    private Rigidbody2D rigid; // 몬스터의 Rigidbody2D 컴포넌트
    private SpriteRenderer sprite;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (playerTransform != null)
        {
            // 플레이어 방향 벡터 계산 및 단위 벡터화
            Vector2 dirVec = ((Vector2)playerTransform.position - rigid.position).normalized;

            // Rigidbody2D를 이용하여 플레이어를 향해 이동
            rigid.MovePosition(rigid.position + dirVec * speed * Time.deltaTime);

            // 몬스터가 플레이어를 바라보도록 스프라이트의 방향 설정
            if (dirVec.x > 0) // 오른쪽을 바라볼 때
            {
                sprite.flipX = false; // 스프라이트를 원래 방향으로
            }
            else if (dirVec.x < 0) // 왼쪽을 바라볼 때
            {
                sprite.flipX = true; // 스프라이트를 뒤집음
            }
        }
    }

    // 플레이어 Transform 설정 메서드
    public void SetPlayerTransform(Transform player)
    {
        playerTransform = player;
    }

   
}
