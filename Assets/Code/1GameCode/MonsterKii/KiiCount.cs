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
