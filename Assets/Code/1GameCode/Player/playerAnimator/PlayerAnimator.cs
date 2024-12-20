/*
# ----------------------------------------------------------------------------------------
#파일이름 :PlayerAnimator.cs
#작성자 : 장승배
#생성일 : 2024.10.06
#내용 :  캐릭터의 애니메이션을 적용하는 코드이다 
# ------------------------------------------------------------------------------------------
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    [SerializeField] Animator animator;
    private bool slideBool = false; 
    float time = 0;
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    void Update()
    
    {
        float moveX= Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        float moveXCpoe = moveX;
        float moveYCpoe = moveY;
        if (moveXCpoe == 0 && moveYCpoe == 0)    
        {
            animator.Play("penguin_idle");
        }
        else if (moveXCpoe != 0 || moveYCpoe != 0 && slideBool == false)    
        {
            animator.Play("penguin_walk");
            
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            slideBool = true;
            

            time = time + Time.deltaTime;
            
        }

        if(moveXCpoe != 0 && slideBool == true)
        {
            animator.Play("penguin_slide");
        }


        if (time < 3f && slideBool == true)
        {
            slideBool = false;
            time =0;
        }


        //slideBool = false;  

    
    }
}
