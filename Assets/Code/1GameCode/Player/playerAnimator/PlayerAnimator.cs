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
        float move = Input.GetAxisRaw("Horizontal");

        float moveCpoe = move;

        if (moveCpoe == 0 )    
        {
            animator.Play("penguin_idle");
        }
        else if (moveCpoe !=0 && slideBool == false)    
        {
            animator.Play("penguin_walk");
            
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            slideBool = true;
            

            time = time + Time.deltaTime;
            
        }

        if(moveCpoe !=0 && slideBool == true)
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
