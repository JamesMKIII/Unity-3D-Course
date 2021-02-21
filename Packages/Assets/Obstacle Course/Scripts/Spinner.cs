using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float xSpeed;
    [SerializeField] float ySpeed;
    [SerializeField] float zSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xSpeed, ySpeed, zSpeed);
    }
}
