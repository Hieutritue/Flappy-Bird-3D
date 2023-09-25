using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafixed : MonoBehaviour
{
    Vector3 cam;
    public Transform player;
  
    // Update is called once per frame
    void Update()
    {if(player.position.y-transform.position.y>=2f)
        transform.position =new Vector3(transform.position.x,player.position.y-2f,transform.position.z);
     if(transform.position.y - player.position.y >= 2f)
        transform.position = new Vector3(transform.position.x, player.position.y + 2f, transform.position.z);
    }
}
