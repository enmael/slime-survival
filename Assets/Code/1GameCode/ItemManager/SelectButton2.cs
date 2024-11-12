/*
# ----------------------------------------------------------------------------------------
#�����̸� : SelectButton2.cs 
#�ۼ��� : ��¹�
#������ : 2024.11.11
#���� :  ��ư�� ������ �������� �����ϴ� �ڵ��̴�.
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectButton2 : MonoBehaviour
{
    [SerializeField] GameObject canvasOject;

    [SerializeField] ItemManager3 itemManager3;
    private bool effect = false;


    [SerializeField] AudioSource audioSource;
    public bool Effect
    {
        get { return effect; }
        set { effect = value; } 
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            selectButton();
        }
    }

    public void selectButton()
    {
        StartCoroutine(selectButton2());
        MonsterHp.monsteCount++;
        Time.timeScale = 1f;
        canvasOject.SetActive(false);
        itemManager3.OneBool = true;
        effect = true;

    }

    IEnumerator selectButton2()
    {
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        //MonsterHp.monsteCount++;
        //Time.timeScale = 1f;
        //canvasOject.SetActive(false);
        //itemManager3.OneBool = true;
        //effect = true;
    }
}
