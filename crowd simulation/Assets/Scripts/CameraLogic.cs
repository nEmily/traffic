﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 v = transform.forward;
            v.y = 0;
            transform.position += v;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 v = transform.forward;
            v.y = 0;
            transform.position -= v;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -5, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 5, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(-5, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(5, 0, 0);
        }

    }
}
