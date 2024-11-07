using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectButton : MonoBehaviour
{
    [SerializeField]bool selectBool = false;
    //[SerializeField] Canvas canvas;

    [SerializeField] GameObject canvasOject;

    public bool SelectBool
    {
        get { return selectBool; }
    }
    public void selectButton()
    {
        selectBool = true;
        //canvas.enabled = false;
        canvasOject.SetActive(false);
        MonsterHp.monsteCount++; 
        Time.timeScale = 1f;


    }
}
