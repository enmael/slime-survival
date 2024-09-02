using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public static gamemanager  instance;
    public Move move;
    private void Awake() 
    {
        instance = this; // 자기 자신을 넣는다.    
    }
    
}
