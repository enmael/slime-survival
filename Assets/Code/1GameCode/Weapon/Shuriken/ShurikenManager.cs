/*
# ----------------------------------------------------------------------------------------
#파일이름 : ShurikenManager.cs
#작성자 : 장승배
#생성일 : 2024.11.05
#내용 : A/D 버튼을 누르면 오브젝트가 날아가는 코드(수리검 날리는 코드)
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenManager : MonoBehaviour
{
    [SerializeField] Transform player;
    //[SerializeField] Collider2D Shuriken2D;
    [SerializeField] float speed = 100f;
    [SerializeField] float respawnTime = 5f;

    [SerializeField] bool activate = true;  

    private float time;
    private float moveX2 = 0; 

    //Move move;
    
    private void Start() 
    {
        //Shuriken2D = GetComponent<Collider2D>();
        //move = GetComponent<Move>();    
        Vector3 playerPosition = player.position;
        transform.position = playerPosition;
    }
    void Update()
    {
        time += Time.deltaTime; 
        float t = time/3;

        // if(t > time)
        // {
        //     Shuriken2D.isTrigger = true;
        // }
        if (time < respawnTime)
        {
            if (activate == true) // A/D 입력을 한 번만 받도록
            {
                
                float moveX = Input.GetAxis("Horizontal");  
                moveX2 = moveX;
                activate = false; 
        
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
            //Shuriken2D.isTrigger = true;
        }

        
    }
}
