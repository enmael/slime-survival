/*
# ----------------------------------------------------------------------------------------
#파일이름 :Boxing.cs
#작성자 : 장승배
#생성일 : 2024.11.06
#내용 : 주먹을 플레이어 방향으로 이동시키며, 주먹을 날린 횟수를 측정한다.
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxing : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 10f;
    [SerializeField] float respawnTime = 5f;

    [SerializeField] bool activate = true;  

    private float time;
    private float moveX2 = 0; 

    [SerializeField] int fistCount = 0;   

    public int FistCount
    {
        get { return fistCount; }   
    }
    
    private void Start() 
    {
        Vector3 playerPosition = player.position;
        transform.position = playerPosition;
    }
    void Update()
    {
        time += Time.deltaTime; 

        if (time < respawnTime)
        {
            
            if (activate == true) // A/D 입력을 한 번만 받도록
            {
                float moveX = Input.GetAxis("Horizontal");  
                moveX2 = moveX; 
                activate = false; 
                fistCount++;
            }

            if(moveX2 == 0)
            {
                // 움직이지 않을때는 한 방향으로만 날라감 
                 transform.Translate(1 * speed * Time.deltaTime, 0, 0);
            }
           
            transform.Translate(moveX2 * speed * Time.deltaTime, 0, 0);
            
        }
        else
        {
            Vector3 playerPosition = player.position;
            transform.position = playerPosition;
            time = 0; 
            activate = true;
        }
    }
}
