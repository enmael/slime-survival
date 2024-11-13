/*
# ----------------------------------------------------------------------------------------
#파일이름 : ThorwAxe.cs
#작성자 : 장승배
#생성일 : 2024.10.29
#내용 : A/D 버튼을 누르면 오브젝트가 날아가는 코드  
# ------------------------------------------------------------------------------------------
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThorwAxe : MonoBehaviour
{
    [SerializeField] Move move;
    [SerializeField] Transform player;
    [SerializeField] float speed = 30f;
    [SerializeField] float respawnTime = 2f;

    [SerializeField] bool activate = true;  

    private float time;
    private float moveX2 = 0; 

    [SerializeField] private GameObject axeObject;
    private Collider2D myCollider;
    void Start()
    {  
     
        myCollider = axeObject.GetComponent<Collider2D>(); 
    }
    void Update()
    {
        time += Time.deltaTime; 

        if (time < respawnTime)
        {
            if (activate == true)
            {
                
                float moveX = Input.GetAxis("Horizontal");
                if (moveX == 0)
                {
                    axeObject.SetActive(false);
                }
                else
                {
                    
                    moveX2 = moveX; 
                    activate = false;
            
                }
                
            }
           
            //speed = speed +move.Speed;
            transform.Translate(moveX2 * speed * Time.deltaTime, 0, 0);
        }
        else
        {
            gameObject.SetActive(true);
            Vector3 playerPosition = player.position;
            transform.position = playerPosition;
            time = 0; 
            activate = true;
        }
    }


}
