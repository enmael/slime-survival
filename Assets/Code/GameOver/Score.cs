using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text kiiText; // UI Text 컴포넌트
    private void Start() 
    {
        UpdateKiiCount(MonsterHp.monsteCount);
    }
    private void UpdateKiiCount(int count)
    {

        kiiText.text = string.Format("킬:{0}", count);

    }
}
