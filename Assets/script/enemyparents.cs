using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyparents : MonoBehaviour
{
    public GameObject[] enemy;
    public int[] spawnpoint;
    public int spawntime;
    float speedup = 1;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer <= 0)
        {
            spawn();
            timer = spawntime;
            speedup += 0.1f;
        }
        timer -= Time.deltaTime;
    }

    void spawn()
    {
        int ranspawn = Random.Range(0, spawnpoint.Length);
        int ranenemy = Random.Range(0, enemy.Length);
        GameObject enemyins = Instantiate(enemy[ranenemy],new Vector3 (spawnpoint[ranspawn],10,0),Quaternion.Euler(new Vector3(0, 180, 0)));
        switch(ranenemy)
        {
            case 0:
                enemy1 enemy1 = enemyins.GetComponent<enemy1>();
                enemy1.speed *= speedup;
                break;
            case 1:
                enemy2 enemy2 = enemyins.GetComponent<enemy2>();
                enemy2.speed *= speedup;
                break;
        }
    }

}
