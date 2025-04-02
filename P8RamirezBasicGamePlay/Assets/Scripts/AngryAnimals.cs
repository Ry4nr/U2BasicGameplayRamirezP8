using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryAnimals : MonoBehaviour
{
    public GameObject[] animalPrefab1;
    private float spawnRangeZ = 15;
    private float spawnPosX = 25;
    private float startDelay = 2;
    private float spawnInterval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range( 0, animalPrefab1.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(animalPrefab1[animalIndex], spawnPos,
        animalPrefab1[animalIndex].transform.rotation);
    }

}


