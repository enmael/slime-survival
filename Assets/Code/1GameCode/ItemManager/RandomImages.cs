/*
# ----------------------------------------------------------------------------------------
#�����̸� : RandomImages.cs 
#�ۼ��� : ��¹�
#������ : 2024.11.11
#���� :  ���ݵ� �������� �̹����� ���� �ڵ��̴�.
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomImages : MonoBehaviour
{
    [SerializeField] List<Sprite> ItemImageList = new List<Sprite>();

    [SerializeField] ItemManager3 itemManager3;
    [SerializeField] string itemName;


    [SerializeField] Image itmeImage;
    private void Awake()
    {
        ItemImageList.Capacity = 10;
    }
    private void Update()
    {
        ImageOutput();
    }

    private void ImageOutput()
    {
        itemName = itemManager3.ItemName;

        for (int i = 0; i < ItemImageList.Count; i++) 
        {
            if (ItemImageList[i].name == itemName)
            {
                itmeImage.sprite = ItemImageList[i];
                break;
            }
        }
    }

}
