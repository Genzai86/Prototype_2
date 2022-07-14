using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{   // esto [] indica una array / matriz

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float spawnRangeLR = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {   
        // Metodo en void Start para que empiece al comenzar la partida
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

   
    //Generamos otro metodo void.
    void SpawnRandomAnimal()
    {
        //Se generan aleatoriamente desde animal index y spawn position. Generamos el animal para que aparezca desde arriba, derecha o izquierda.
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 spawnPosLeft = new Vector3(-spawnRangeLR, 0, Random.Range(-5, 30));
        Vector3 spawnPosRight = new Vector3(spawnRangeLR, 0, Random.Range(-5, 30));


        //int = numeros enteros. Decimos que, animalIndex es un numero entero que es igual a un numero aleatorio en un rango que va desde 0 a toda la lista de animalprefabs.
        //Creo 3 spawn para que cada lado cree packs diferentes de animales
       
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int animalIndex1 = Random.Range(0, animalPrefabs.Length);
        int animalIndex2 = Random.Range(0, animalPrefabs.Length);

        // ir al proyecto y comprobar el Gameobject que esta vacio en el que hay una lista.
        // Quaternion para definir rotacion del objeto.
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        Instantiate(animalPrefabs[animalIndex1], spawnPosLeft, Quaternion.Euler(0, 90, 0));
        Instantiate(animalPrefabs[animalIndex2], spawnPosRight, Quaternion.Euler(0, -90, 0));
    }
}