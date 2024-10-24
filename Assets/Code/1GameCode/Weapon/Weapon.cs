using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
  public Transform playerTransform ; // 플레이어의 현재 좌표값 가져옴
    public Vector2 inputV2;
    SpriteRenderer spriteRenderer;

        void Awake() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        // 무기의 위치를 플레이어 위치에 맞추어 업데이트
        transform.position = playerTransform.position + new Vector3(0.5f, 0, 0); // 무기를 플레이어 위치에 맞춰 이동
        transform.rotation = playerTransform.rotation;  // 플레이어 회전에 맞추어 무기 회전
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
