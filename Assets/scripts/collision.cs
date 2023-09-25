using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public GameObject head;
    float check = 0f;
    public movement mm;
    public GameObject logic;
    logic checkscore;
    float timer = 0f;
    public float death = 1f;
    public AudioSource headHit;
    private void Awake()
    {
        checkscore = logic.GetComponent<logic>();
    }
    private void OnCollisionEnter()
    {
        
        
        if (check == 0)
        {
            mm.enabled = false;
            head.AddComponent<Rigidbody>(); check = 1;
            headHit.Play();
            
        }
    }
    private void Update()
    {
        if(check==1)
        {
            timer += Time.deltaTime;
            if (timer >= death) { checkscore.gameOver();  }
        }
    }
    private void OnTriggerEnter()
    {
        
        checkscore.addScore();
        
    }
}
