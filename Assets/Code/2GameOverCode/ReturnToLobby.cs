/*
# ----------------------------------------------------------------------------------------
#파일이름 :ReturnToLobby.cs
#작성자 : 장승배
#생성일 : 2024.10.24
#내용 : 게임 오버씬에서 버튼을 누르면 지정된 씬으로 넘어가게 하는 코드 
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
        MonsterHp.monsteCount = 0;
        TimerUI.timer = 0;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator Restart(string sceneName)
    {
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



}
