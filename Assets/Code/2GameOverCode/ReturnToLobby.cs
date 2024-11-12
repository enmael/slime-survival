/*
# ----------------------------------------------------------------------------------------
#파일이름 :ReturnToLobby.cs
#작성자 : 장승배
#생성일 : 2024.10.24
#내용 : 게임 오버씬에서 버튼을 누르면 지정된 씬으로 넘어가게 하는 코드 
#수정일 : 2024.11.12
#수정내용 : - 버튼을 눌렀을때 BGM이 끝나고 다음씬으로 넘어가게 수정
# ------------------------------------------------------------------------------------------
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToLobby : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;
    public void ReturnLobby()
    {

        StartCoroutine(Load("LobbyScene"));
    }

    public void GameRestart()
    {
       StartCoroutine(Restart("GameScene"));
    }

    public void ExitGame()
    {
        StartCoroutine(Exit());
    }

    IEnumerator Load(string sceneName)
    {
        ScoreReset();
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator Restart(string sceneName)
    {
        ScoreReset();
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        SceneManager.LoadScene(sceneName);
    }


    IEnumerator Exit()
    {
        audioSource.Play(); 
        yield return new WaitForSeconds(audioSource.clip.length); 
        Application.Quit();  
        Debug.Log("게임 종료");
    }

    private void ScoreReset()
    {
        MonsterHp.monsteCount = 0;
        TimerUI.timer = 0;
    }



}
