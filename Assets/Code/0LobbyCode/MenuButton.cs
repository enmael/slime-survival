/*
# ----------------------------------------------------------------------------------------
#파일이름 :MenuButtons.cs
#작성자 : 장승배
#생성일 : 2024.10.21
#내용 : 버튼을 클릭했을때 버튼에 맞는 이벤트가 발생하느 코드이다 
#수정일 : 2024.11.12
#수정내용 : 버튼을 누르면 BGM이 모두 재생되고 다음씬으로 넘어가게수정
# ------------------------------------------------------------------------------------------
*/
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    // 인스펙터에서 AudioSource 연결할 수 있도록 SerializeField 사용
    [SerializeField] AudioSource audioSource;  // 효과음용 AudioSource

    // "GameScene"이라는 이름의 씬을 로드
    public void StartGame()
    {
        StartCoroutine(PlaySoundAndLoadScene("GameScene"));
    }

    // 게임 종료
    public void ExitGame()
    {
        StartCoroutine(PlaySoundAndExit());
    }

    // 소리 재생 후 씬 전환을 위한 Coroutine
    IEnumerator PlaySoundAndLoadScene(string sceneName)
    {
        audioSource.Play();  // 버튼 클릭 시 소리 재생
        yield return new WaitForSeconds(audioSource.clip.length);  // 소리가 끝날 때까지 기다림
        SceneManager.LoadScene(sceneName);  // 씬 전환
    }

    // 소리 재생 후 게임 종료를 위한 Coroutine
    IEnumerator PlaySoundAndExit()
    {
        audioSource.Play();  // 버튼 클릭 시 소리 재생
        yield return new WaitForSeconds(audioSource.clip.length);  // 소리가 끝날 때까지 기다림
        Application.Quit();  // 게임 종료
        Debug.Log("게임 종료");
    }
}

