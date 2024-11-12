////using UnityEngine;
////using UnityEngine.UI;  // UI 관련 네임스페이스 추가

////public class ButtonSound : MonoBehaviour
////{
////    public AudioSource audioSource;  // AudioSource를 연결할 변수
////    public Button button;  // 버튼을 연결할 변수

////    void Start()
////    {
////        // 버튼의 클릭 이벤트에 소리 재생 함수를 연결
////        button.onClick.AddListener(PlaySound);
////    }

////    // 버튼 클릭 시 소리 재생 함수
////    void PlaySound()
////    {
////        audioSource.Play();  // 소리 재생
////    }
////}

//using System.Collections;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class ButtonSound : MonoBehaviour
//{
//    // 효과음 재생을 위한 AudioSource
//    [SerializeField] AudioSource audioSource;

//    // "GameScene"이라는 이름의 씬을 로드
//    public void StartGame()
//    {
//        // StartGame 호출 시 소리 재생 후 씬 전환
//        StartCoroutine(PlaySoundAndLoadScene("GameScene"));
//    }

//    // 게임 종료
//    public void ExitGame()
//    {
//        // ExitGame 호출 시 소리 재생 후 종료
//        StartCoroutine(PlaySoundAndExit());
//    }

//    // 소리 재생 후 씬 전환을 위한 Coroutine
//    IEnumerator PlaySoundAndLoadScene(string sceneName)
//    {
//        // 소리 재생
//        audioSource.Play();

//        // 소리 길이만큼 기다린 후 씬 전환
//        yield return new WaitForSeconds(audioSource.clip.length);

//        // 씬 전환
//        SceneManager.LoadScene(sceneName);
//    }

//    // 소리 재생 후 게임 종료를 위한 Coroutine
//    IEnumerator PlaySoundAndExit()
//    {
//        // 소리 재생
//        audioSource.Play();

//        // 소리 길이만큼 기다린 후 종료
//        yield return new WaitForSeconds(audioSource.clip.length);

//        // 게임 종료
//        Application.Quit();
//        Debug.Log("게임 종료");
//    }
//}

