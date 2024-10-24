using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReturnToLobby : MonoBehaviour
{
public void ReturnLobby()
{    
    SceneManager.LoadScene("LobbyScene");

}

public void ExitGame()
{
    Application.Quit();
        
    Debug.Log("게임 종료");
}

}
