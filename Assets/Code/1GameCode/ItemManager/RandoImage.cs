using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class RandoImage : MonoBehaviour
{
    public Image itmeImage;

    [SerializeField] List<Sprite> itemImages = new List<Sprite>(); 
    [SerializeField] ItemManager2 itemManager2;

    private bool itemManager2ItmeNameBool = true;  
    private string itmename;
    private void Start() 
    {
        itemImages.Capacity = 10;
    }

    private void Update() 
    {
        
        //if(itemManager2ItmeNameBool == true)
        //{
            itmename = itemManager2.StartWeaponName;
        //    itemManager2ItmeNameBool =false;
        //}
        // else
        // {

        // }
       
        //Debug.Log ("아이템 이름 : "+itmename);   

        for(int i = 0; i< itemImages.Count; i++)
        {
            if(itemImages[i].name == itmename)
            {
                itmeImage.sprite = itemImages[i];   
                break;
            }
        } 
    }
}
