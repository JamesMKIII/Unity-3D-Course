using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMover : MonoBehaviour
{
    float xValue;
    float zValue;

    // Start is called before the first frame update
    void Start()
    {
        xValue = 0;
        zValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        MoveBoard();
    }

    private void MoveBoard()
    {
        xValue = Input.GetAxis("Vertical");
        zValue = Input.GetAxis("Horizontal");

        transform.Rotate(xValue, 0, -zValue);
    }
}
