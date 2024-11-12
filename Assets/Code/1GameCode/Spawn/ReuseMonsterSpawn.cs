/*
# ----------------------------------------------------------------------------------------
#파일이름 :ReuseMonsterSpawn.cs
#작성자 : 장승배
#생성일 : 2024.10.31
#내용 : 일단 몬스터를 생성하고 제 생산하는애 한테 넘긴다.
# ------------------------------------------------------------------------------------------
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReuseMonsterSpawn : MonoBehaviour
{
    [SerializeField] List<GameObject> gameObjectsList = new List<GameObject>();

    [SerializeField] GameObject RightSpawnManager;
    [SerializeField] GameObject LeftSpawnManager;

    [SerializeField] bool gameObjectsListBool = false;  // true 이면 작동 


    private bool rightbool = true;
    private bool leftbool = false;

    public bool gameObjectsListBoolS
    {
        get { return gameObjectsListBool; }
        set { gameObjectsListBool = value; }
    }

    public List<GameObject> gameObjectsListS
    {
        get { return gameObjectsList; }
        set { gameObjectsList = value; }
    }


    // private void Start() 
    // {
    //     StartCoroutine(ReuseMonsterSpawnCoroutine());
    // }
    //  IEnumerator ReuseMonsterSpawnCoroutine()
    // {
    //     while (gameObjectsListBool == true)
    //     {
    //         Debug.Log("Dsadasds!!wasdda!!");
    //         Location();
    //         yield return new WaitForSeconds(0.3f);
    //     }
    // }

    private void Update()
    {
        if (gameObjectsListBool == true)
        {
            //Debug.Log("Dsadasds!!wasdda!!");
            Location();
        }

    }

    private void ReuseSpawn(Vector2 vector2)
    {
        for (int i = 0; i < gameObjectsList.Count; i++)
        {
            //Debug.Log("Dsadasds");
            if (gameObjectsList[i].activeSelf == false)
            {
                GameObject gameObject = gameObjectsList[i];
                gameObject.SetActive(true);
                gameObject.transform.position = vector2;
                gameObjectsList.RemoveAt(i);
                gameObjectsList.Add(gameObject);

            }
        }
    }

    private void Location()
    {
        if (rightbool == true)
        {
            Vector2 vector2 = RightSpawnManager.transform.position;
            ReuseSpawn(vector2);
            rightbool = false;
            leftbool = true;

        }
        if (leftbool == true)
        {
            Vector2 vector2 = LeftSpawnManager.transform.position;
            ReuseSpawn(vector2);
            leftbool = false;
            rightbool = true;

        }
    }



}
