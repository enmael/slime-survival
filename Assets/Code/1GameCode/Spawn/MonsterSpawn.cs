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

    private void Start()
    {
        StartCoroutine(MonsterSpawnCoroutine());
    }

    IEnumerator MonsterSpawnCoroutine()
    {
        while (count < monstersNumber)
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
    }


    private void RemoveCloneName(GameObject clone)
    {
        if (clone.name.EndsWith("(Clone)"))
        {
            clone.name = clone.name.Replace("(Clone)", "") + count;
        }
    }
}
