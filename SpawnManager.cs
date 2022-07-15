using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; //this [] indicates array

    public float startTime = 2;
    public float spawnInterval = 1.5f;
    public float spawnRangeLR = 15;

    public float spawnRangeX = 10;
    public float spawnPosZ = 27;


    // Start is called before the first frame update
    void Start()
    {
        //Invoke repeating is a function that calls on a method based on the time parameters you give it
        //Arguments: ("Function", TimeStart, Interval)
        InvokeRepeating("SpawnRandomAnimal", startTime, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        //randomise spawn location
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 spawnPosLeft = new Vector3(-spawnRangeLR, 0, Random.Range(6, 20));
        Vector3 spawnPosRight = new Vector3(spawnRangeLR, 0, Random.Range(6, 20));

        //randomly generate an animal to spawn
        //I created 3 spawns here so that each side creates a different batch of animals
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int animalIndex2 = Random.Range(0, animalPrefabs.Length);
        int animalIndex3 = Random.Range(0, animalPrefabs.Length);

        //actual piece of code spawning animals
        //there are various ways to put arguments, but over here it's (object, Vector3 position, Quaterion.position)
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

        Instantiate(animalPrefabs[animalIndex2], spawnPosLeft, Quaternion.Euler(0, 90, 0));

        Instantiate(animalPrefabs[animalIndex3], spawnPosRight, Quaternion.Euler(0, -90, 0));

    }
}