using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefab;
    private float spawnPosZ = 20;


    private float spawnRangeX = 20;
    
   

    private float repeatRateInterval = 1.5f;
    private float startDelay = 2f;

    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, repeatRateInterval);
        InvokeRepeating("SpawnLeftAnimal", startDelay, repeatRateInterval);
        InvokeRepeating("SpawnRightAnimal", startDelay, repeatRateInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
  
        
    }

    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);        
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefab[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefab[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
       // Vector3 spawnPosRight = new Vector3(-spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));

       Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
      //  Instantiate(animalPrefab[animalIndex], spawnPosRight, animalPrefab[animalIndex].transform.rotation);
    }
}
