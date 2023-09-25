using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclespawn : MonoBehaviour
{
    public GameObject obstacle;
    public float timer=0f;
    public float timeToSpawn=60f;
    public float topBound, bottomBound;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer>=timeToSpawn)
        {
            spawn();
            timer= 0f;
        }
    }
    void spawn()
    {
        float random = Random.Range(topBound,bottomBound);
        Instantiate(obstacle,transform.position+new Vector3(0,random,0), Quaternion.identity);

    }
    
}
