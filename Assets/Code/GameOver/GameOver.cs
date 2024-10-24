using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    Damage damage;
    public bool GameOverconte = false; 

      public bool GameOverConte
    {
      get { return GameOverconte; }
    }
    private void Awake() 
    {
        damage = GetComponent<Damage>();    
    }

    private void Update() {
        if (damage.CurrentHealth == 0)
        {
            SceneManager.LoadScene("GameOverScene");
            GameOverconte = true;   
        } 
    }    
 }
