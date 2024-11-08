/*
# ----------------------------------------------------------------------------------------
#파일이름 :KiiCount.cs
#작성자 : 장승배
#생성일 : 2024.10.08
#내용 :  게임씬에 킬한 몬스터의 숫자를 표기하는 코드이다.
# ------------------------------------------------------------------------------------------
*/


using UnityEngine;
using UnityEngine.UI;

public class KiiCount : MonoBehaviour
{
    public Text kiiText; // UI Text 컴포넌트
    private void Update()
    {

        UpdateKiiCount(MonsterHp.monsteCount);
        //Debug.Log("count:" + MonsterHp.monsteCount);

    }

    private void UpdateKiiCount(int count)
    {

        kiiText.text = string.Format("{0}", count);

    }
}
