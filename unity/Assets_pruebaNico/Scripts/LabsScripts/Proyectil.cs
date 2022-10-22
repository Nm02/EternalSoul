using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Usar()
    {
        rb.AddForce(transform.forward, ForceMode.Impulse);
        Destroy(gameObject, 5);
    }
}
