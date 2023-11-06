using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private GameObject[] BallsPrefabsArray;
    private int BallsIndex;

    private float spawnRangeX = 15f;
    private float SpawnPosY = 28f;

    [SerializeField] private float StartDelay = 2f;
    [SerializeField] private float SpawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnRandomBall", StartDelay, SpawnInterval);


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnRandomBall()
    {
        BallsIndex = Random.Range(0, BallsPrefabsArray.Length);
        Instantiate(BallsPrefabsArray[BallsIndex],
            RandomSpawnPos(),
            Quaternion.Euler(90, 0, 0));
    }

    private Vector3 RandomSpawnPos()
    {
        float randomx = Random.Range(-28, 8);
        return new Vector3(randomx, SpawnPosY, 0);

    }
}
