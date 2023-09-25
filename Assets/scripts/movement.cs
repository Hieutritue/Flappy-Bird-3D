using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public AudioSource jumpSFX;
    public float power = 12f;
    public KeyCode key;
    public Rigidbody rb;
    bool jump;
    private void Awake()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
       
        if (Input.GetKeyDown(key)) { 
            rb.velocity = Vector3.zero; 
            rb.AddForce(Vector3.up * power  );
            jumpSFX.Play();
            Time.timeScale = 1;
        }
    }
  
}
