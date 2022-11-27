using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    float spawnTime;
    int prefeb_num;
    public GameObject[] prefebs;
    

    void Start()
    {
        SpawnBirds();
        InvokeRepeating("SpawnPlayers", spawnTime, spawnTime);

    }
    void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime < 0)
        {
            prefeb_num = Random.Range(0, 2);
            SpawnBirds();
            spawnTime = Random.Range(0.5f, 2);
        }
    }
    void SpawnBirds()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        int objectIndex = Random.Range(0, prefebs.Length);
        GameObject bird = Instantiate(prefebs[objectIndex], spawnPoints[spawnIndex].position, Quaternion.identity);
            if (bird.transform.position.x > transform.position.x)
            {
                bird.GetComponent<SpriteRenderer>().flipX = spawnPoints[spawnIndex].position.x > 0;
                bird.GetComponent<Rigidbody2D>().AddForce(new Vector2(-400, 100));
            }

    }
}
