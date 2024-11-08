/*
# ----------------------------------------------------------------------------------------
#파일이름 :Axe.cs
#작성자 : 장승배
#생성일 : 2024.10.29
#내용 : 오브젝트가 회전하게 하는 코드 
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 300f;
    
    void Update()
    {
        transform.Rotate(new Vector3(0,0,1), rotationSpeed * Time.deltaTime);  
    }
}
