﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;

    public AudioSource audioSource;

    public static bool isCrashed;
    [SerializeField] float mainThrust = 100f;
    [SerializeField] float rotationThrust = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isCrashed = false;
    }

    // Update is called once per frame
    void Update()
    {
        ThrustInput();
        RotationInput();
    }

    private void ThrustInput()
    {
        if ((Input.GetKey(KeyCode.Space) == true) && (isCrashed == false))
        {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
            
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }

    private void RotationInput()
    {
        if ((Input.GetKey(KeyCode.A) == true) && (isCrashed == false))
        {
            Rotate(rotationThrust);
        }
        else if ((Input.GetKey(KeyCode.D)) && (isCrashed == false))
        {
            Rotate(-rotationThrust);
        }
    }

    private void Rotate(float rotationThisFrame)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }
}
