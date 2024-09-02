using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reforged : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other) 
    {
        // 트리거 체크된 콜라이더 밖으로 나가면 이벤트 발생 
     if(! other.CompareTag("Area"))
     {
        return;
        //Area 태그가 아니면 실행x
     }
        Vector3 playPos = gamemanager.instance.move.transform.position;
        Vector3 myPos = transform.position; 

        float diffx =Mathf.Abs(playPos.x - myPos.x); 
        float diffy =Mathf.Abs(playPos.y - myPos.y); 

        

        switch(transform.tag)
        {
            case "Ground" :
            if (diffx > diffy)
            {
                transform.Translate(Vector3.right* diffx * 40);
            }
            else if (diffx < diffy)
            {
                transform.Translate(Vector3.up * diffy * 40);
            } 
            break;

            case "Enemy" :
            break;

        }

    }
}
