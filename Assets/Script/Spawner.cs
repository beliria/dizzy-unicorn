using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabTuberias;
    public float randomRange = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstaculo", 0F, 2.54F);
    }

    void SpawnObstaculo()
    {
        Vector3 spawnPositionFede;
        spawnPositionFede.x = transform.position.x;
        spawnPositionFede.y = Random.Range(randomRange, -randomRange);
        spawnPositionFede.z = transform.position.z;

        Instantiate(prefabTuberias, spawnPositionFede, Quaternion.identity);
    }
}
