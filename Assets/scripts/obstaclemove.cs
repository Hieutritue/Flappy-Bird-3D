using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclemove : MonoBehaviour
{
    public float speed = 12f;
    public float zBound = 12f;
    void Update()
    {
        moveDestroy();
    }
    public void moveDestroy()
    {
        transform.position = transform.position - new Vector3(0, 0, speed * Time.deltaTime);
        if (transform.position.z < zBound) Destroy(gameObject);
    }
}
