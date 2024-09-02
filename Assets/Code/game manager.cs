using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{   
    #region 원본 코드
    // public static gamemanager  instance;
    // public Move move;
    // private void Awake() 
    // {
    //     instance = this; // 자기 자신을 넣는다.    
    // }
    #endregion

    #region 수정된 코드 
    public static gamemanager instance; // 싱글톤 인스턴스
    public Move move; // 플레이어 또는 타겟 오브젝트

    private void Awake() 
    {
        // 싱글톤 패턴: 인스턴스가 이미 존재하면 현재 오브젝트를 파괴
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // 씬 전환 시 오브젝트가 파괴되지 않도록 설정
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // 근대 구지 여기에 싱글톤 을 사용해야 되나 ?
    // 어차피 한 씬에서 모든걸 다 처리하는 게임 인데...
    #endregion

}
