using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWalkSound : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    [SerializeField] 
    private AudioSource audioSource;
    // Update is called once per frame
    void Update()
    {
     if(rb.velocity.x > 0f || rb.velocity.z > 0f || rb.velocity.x < 0f || rb.velocity.z < 0f)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }   
    }
}
