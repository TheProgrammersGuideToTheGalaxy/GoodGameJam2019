using Gamekit2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private ItemsSpawner[] spawners;

    public void OnHitTaken(Damageable damage)
    {
        foreach(ItemsSpawner element in spawners){
            element.SpawnWithId(damage.CurrentHealth + 1);
        }
    }
}
