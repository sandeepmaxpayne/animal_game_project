using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefab;
    private float spawnPosZ = 20;
    private float spawnRangeX = 20;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
        }
        
    }
}
