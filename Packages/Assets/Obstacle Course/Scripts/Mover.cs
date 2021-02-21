using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    private void Start()
    {
        PrintInstructions();
    }

    private void Update()
    {
        MovePlayer();
    }

    private void PrintInstructions()
    {
        Debug.Log("Move your ball with WASD");
        Debug.Log("Try to reach the end while hitting as few obstacles as possible.");
    }

    private void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
