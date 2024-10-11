using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundPlayer : MonoBehaviour
{
    public Transform player;  // 플레이어의 위치
    [SerializeField]public float rotationSpeed = 50f;  // 회전 속도
    [SerializeField]public float distanceFromPlayer = 2f;  // 플레이어와의 거리


     private void Update()
    {
        //Vector2 dis = new Vector2(distanceFromPlayer,distanceFromPlayer);

        // 플레이어와 일정 거리를 유지하면서 회전
        transform.position = player.position + (transform.position - player.position).normalized * distanceFromPlayer;
        
        // Vector2 PosX= transform.position - player.position;

        // if(dis.x < PosX.x)
        // {

        // }
        
        // 플레이어 주변에서 회전
        transform.RotateAround(player.position, Vector3.forward, rotationSpeed * Time.deltaTime);

    }
}
