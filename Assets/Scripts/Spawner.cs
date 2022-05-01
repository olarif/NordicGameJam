using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner instance;

    public List<GameObject> spawnPoints;

    //public GameObject[] spawners;

    public GameObject enemy;

    void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        foreach (GameObject obj in spawnPoints)
        {
            Instantiate(enemy, obj.transform.position, obj.transform.rotation);
        }
    }

    public void Spawn(){
        foreach (GameObject obj in spawnPoints)
        {
            Debug.Log("Spawning all");
            Instantiate(enemy, obj.transform.position, obj.transform.rotation);
        }
    }

    public void DestroyAllObjects()
    {
        var gameObjects = GameObject.FindGameObjectsWithTag ("NPC");
     
        for(var i = 0 ; i < gameObjects.Length ; i ++)
        {
            Destroy(gameObjects[i]);
        }
    }
}
