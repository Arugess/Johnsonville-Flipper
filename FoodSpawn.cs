using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This will spawn a random condiment or hotdog from a random spawnpoint in the level.//

public class FoodSpawn : MonoBehaviour
{
    //[] this allows for lists to be made in the editor
    public Transform[] spawnPoint;
    public GameObject[] foodPrefab;
    int whichSpawnPoint;
    int foodNumber;

	void Start ()
    {
        StartCoroutine("GetFoodSpawning");

    }
	

	void Update ()
    {
        //The update will randomly switch between all the variables in the range
        whichSpawnPoint = Random.Range(0, 6);
        foodNumber = Random.Range(0, 6);

    }

    public IEnumerator GetFoodSpawning()
    {
        yield return new WaitForSeconds(2.0f);

        //Spawns a random prefab at a random spawnpoint
        Instantiate(foodPrefab[foodNumber], spawnPoint[whichSpawnPoint].position, Quaternion.identity);

        //Loops the coroutine
        StartCoroutine("GetFoodSpawning");
    }
}
