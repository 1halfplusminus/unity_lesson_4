using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public SpawnableGroups enemyGroup;
    public SpawnableGroups powerUpGroup;
    public SpawnZone spawnZone;
    // Start is called before the first frame update

    public void IncrementSpawn()
    {
        enemyGroup.quantity += 1;
        if (powerUpGroup.quantity.total < 3)
        {
            powerUpGroup.quantity += 1;
        }
    }

    public void SpawnPowerUp()
    {
        StartCoroutine(powerUpGroup.Spawn(spawnZone));
    }
}
