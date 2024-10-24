using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] Item;

    public Transform playerTransform;

    private int count = 0;

    public GameObject[] ItemList
    {
        get { return Item; } // 배열을 반환
    }

    private void Start()
    {
        StartCoroutine(ItemSpawen());
    }

    IEnumerator ItemSpawen()
    {
        while (true)
        {
            SpawnPosition();
            count++;
            yield return new WaitForSeconds(2f);
        }
    }

    void SpawnPosition()
    {
        int typeMonsters = Item.Length;
        if (playerTransform != null)
        {
            Vector2 playerPosition = playerTransform.position;

            System.Random rand = new System.Random();

            float xPos = rand.Next((int)playerPosition.x - 20, (int)playerPosition.x + 20);
            float yPos = rand.Next((int)playerPosition.y - 20, (int)playerPosition.y + 20);

            int rannum = rand.Next(0, typeMonsters);

            Vector2 randomPos = new Vector2(xPos, yPos);


            GameObject monster = Instantiate(Item[rannum], randomPos, Quaternion.identity);

            RemoveCloneName(monster);


        }
    }

    void RemoveCloneName(GameObject clone)
    {
        if (clone.name.EndsWith("(Clone)"))
        {
            clone.name = clone.name.Replace("(Clone)", "");

        }
    }

}
