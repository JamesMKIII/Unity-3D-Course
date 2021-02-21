using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDrop : MonoBehaviour
{
    [SerializeField] float timer = 3f;

    MeshRenderer render;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        render = GetComponent<MeshRenderer>();
        render.enabled = false;
    }
    private void Update()
    {
        if (Time.time >= timer)
        {
            render.enabled = true;
            rb.useGravity = true;

        }

    }
}
