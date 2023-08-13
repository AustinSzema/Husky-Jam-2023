using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    [SerializeField] private float power = 1000f;

    [SerializeField] private Transform carTransform;
    private Vector3 explosionPos;

    [SerializeField] private float explosionRadius = 2000f;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            explosionPos = carTransform.position - new Vector3(0f, carTransform.localScale.y / 2f, 0f);
            rb.AddExplosionForce(power, explosionPos, explosionRadius, 3.0f);
            //rb.AddForce(Vector3.up * 1000000);
        }
        
    }
}
