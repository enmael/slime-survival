/*
# ----------------------------------------------------------------------------------------
#파일이름 :Fist.cs
#작성자 : 장승배
#생성일 : 2024.11.06
#내용 : 주먹이 새번째에는 커져서 나가는 코드이다.
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fist : MonoBehaviour
{
    [SerializeField]GameObject fist;
    [SerializeField] private Boxing boxing;
    
    private void Start() 
    {
        StartCoroutine(FistCoroutine());    
    }

    private void Update()
    {
        //float moveX = Input.GetAxis("Horizontal");
        //if (moveX < 0)
        //{
        //    fist.transform.Rotate(180, 0, 0);
        //}
        //else
        //{
        //    fist.transform.Rotate(0, 0, 0);
        //}
    }
    private IEnumerator FistCoroutine()
    {
        
        while (true)
        {
            if(boxing.FistCount%3 == 0)
            {
                fist.transform.localScale = new Vector2(10, 10);
            } 
            else
            {
                fist.transform.localScale = new Vector2(5, 5);
            }
            yield return null;
        }
      
    }
}
