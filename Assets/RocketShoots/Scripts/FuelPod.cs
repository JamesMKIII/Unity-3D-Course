using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelPod : MonoBehaviour
{
    Rigidbody rb;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        this.gameObject.SetActive(false);
    }
}
