/*
# ----------------------------------------------------------------------------------------
#파일이름 :MonsterSpawn.cs
#작성자 : 장승배
#생성일 : 2024.10.31
#내용 : 좌우로 지정한 숫자 만큼 몬스터를 새성하는 코드 
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    [SerializeField] GameObject RightSpawnManager;
    [SerializeField] GameObject LeftSpawnManager;


    [SerializeField] GameObject[] monsterObjects; 
    [SerializeField] int monstersNumber = 30;  
    [SerializeField] float spawnTime = 1.0f; 


    public Transform playerTransform;
    private int count = 0;  
    private bool rightbool = true; 
    private bool leftbool = false;  


    ReuseMonsterSpawn reuseMonsterSpawn;   

    private void Awake() 
    {
        reuseMonsterSpawn  = FindObjectOfType<ReuseMonsterSpawn>();
    }
    private void Start()
    {
        StartCoroutine(MonsterSpawnCoroutine());
        
    }
    private void Update()
    {
        if(monstersNumber == MonsterHp.monsteCount)
        {
            reuseMonsterSpawn.gameObjectsListBoolS = true;
            Debug.Log("리사이클 코드로 넘어감 ");
        }
    }

    IEnumerator MonsterSpawnCoroutine()
    {
        while (monstersNumber > count )
        {
            Location();
            
            yield return new WaitForSeconds(spawnTime);
        }
    }

    private void Location()
    {
        if (rightbool == true)
        {
            Vector2  vector2 = RightSpawnManager.transform.position;
            Spawn(vector2);
            rightbool = false;
            leftbool = true;
            count++;
        }
        if (leftbool == true)
        {
            Vector2  vector2 = LeftSpawnManager.transform.position;
            Spawn(vector2);
            leftbool = false;
            rightbool = true;
            count++;
        }   
    }

    private void Spawn(Vector2 vector2)
    {
        int randomIndex = UnityEngine.Random.Range(0, monsterObjects.Length);
        GameObject monster = Instantiate(monsterObjects[randomIndex], vector2, Quaternion.identity);
        
        MonsterChase monsterChase = monster.GetComponent<MonsterChase>();
        if (monsterChase != null)
        {
            monsterChase.SetPlayerTransform(playerTransform);
        }
        RemoveCloneName(monster);
        reuseMonsterSpawn.gameObjectsListS.Add(monster);

    }


    private void RemoveCloneName(GameObject clone)
    {
        if (clone.name.EndsWith("(Clone)"))
        {
            clone.name = clone.name.Replace("(Clone)", "");
        }
    }
}
