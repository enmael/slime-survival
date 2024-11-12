//using System.Collections.Generic;
//using Unity.VisualScripting;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class BGMController : MonoBehaviour
//{
//    public AudioClip bgm;  // 배경 음악
//    private AudioSource audioSource;
//    void Awake()
//    {
//        // 씬이 변경되어도 BGM 오브젝트가 파괴되지 않도록 설정
//        DontDestroyOnLoad(gameObject);  // 이 객체는 씬 전환 시에도 파괴되지 않음
//    }

//    void Start()
//    {
//        audioSource = GetComponent<AudioSource>();

//        // 음악이 없으면 초기화
//        if (audioSource == null)
//        {
//            audioSource = gameObject.AddComponent<AudioSource>();
//        }

//        // BGM을 무한 루프하도록 설정
//        if (bgm != null)
//        {
//            audioSource.clip = bgm;
//            audioSource.loop = true;  // 무한 루프
//            audioSource.Play();
//        }
//    }
//}
using UnityEngine;

public class BGMController : MonoBehaviour
{
    public static BGMController instance;
    public AudioClip bgm;  // 배경 음악
    private AudioSource audioSource;

    void Awake()
    {
        // 이미 인스턴스가 존재하면 이 객체를 파괴
        if (instance != null && instance != this)
        {
            Destroy(gameObject);  // 중복된 객체는 삭제
            return;
        }
        else
        {
            instance = this;  // 현재 객체를 인스턴스로 설정
        }

        // 씬 전환 시에도 BGM 오브젝트가 파괴되지 않도록 설정
        DontDestroyOnLoad(gameObject);  // 이 객체는 씬 전환 시에도 파괴되지 않음
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // 음악이 없으면 초기화
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // BGM을 무한 루프하도록 설정
        if (bgm != null && !audioSource.isPlaying)
        {
            audioSource.clip = bgm;
            audioSource.loop = true;  // 무한 루프
            audioSource.Play();
        }
    }

    // 필요하다면 음악을 정지하는 메서드
    public void StopBGM()
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }

    // 이름으로 BGMController 찾기
    public static BGMController FindBGMControllerByName(string name)
    {
        GameObject bgmObject = GameObject.Find(name);  // 이름으로 GameObject 찾기
        if (bgmObject != null)
        {
            // GameObject에서 BGMController 컴포넌트를 가져오기
            return bgmObject.GetComponent<BGMController>();
        }
        else
        {
            Debug.LogWarning("BGMController not found with name: " + name);
            return null;
        }
    }
}

