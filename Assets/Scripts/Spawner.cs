using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemy;
    private float randY;
    private Vector2 whereToSpawn;
    public float spawnRate; //2f
    private float nextSpawn = 0.0f;
    private int randEnemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            int randEnemy = Random.Range(0, enemy.Length); //random enemy spawn based on length of sprites
            nextSpawn = Time.time + spawnRate; //time until next spawn
            randY = Random.Range(2.75f,-2.20f); //the range where enemy spawns
            whereToSpawn = new Vector2(transform.position.x, randY); //the position where it spawns
            Instantiate(enemy[randEnemy], whereToSpawn, Quaternion.identity);
        }
    }
}
