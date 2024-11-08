// //폐기 

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class LaunchingPad : MonoBehaviour
// {
    
//     [SerializeField] GameObject RightPad;
//     [SerializeField] GameObject LeftPad;
//    // Move move;

//     // private void Start() 
//     // {
//     //     move = GetComponent<Move>();
    
//     // }
//     // [SerializeField] GameObject Pad;

//     private void Update()
//     {
//         float movement = Input.GetAxisRaw("Horizontal");
//         float sc = movement;

//        if (sc > 0)
//        {
//             LeftPad.SetActive(false);
//             RightPad.SetActive(true); 
//        }
//        else if(sc < 0)
//        {
//             RightPad.SetActive(false); 
//             LeftPad.SetActive(true);
//        }
    
//     } 

// }
