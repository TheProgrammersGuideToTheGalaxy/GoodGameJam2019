using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] thingsToSpawn;
    [SerializeField] private int remainingHealth;

    public void SpawnWithId(int id)
    {
        Debug.Log(id);
        if(id == remainingHealth)
        {
            Debug.Log("Preparing the spawner!");
            SpawnItem();
        }
    }

    public void SpawnItem()
    {
        foreach(GameObject element in thingsToSpawn)
        {
            Instantiate(element, transform.position, Quaternion.identity);
            Debug.Log("Spawned!");
        }

    }
}
