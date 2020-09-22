﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed = 0f;
    private float time = 1f;
    private bool left = true;
    private void OnCollisionEnter(Collision collision)
    {
        speed += 0.01f;
    }
    void Update()
    {
        if (left)
        {
            transform.Translate(Vector3.left * speed);
        }
        else
        {
            transform.Translate(Vector3.right * speed);
        }

        if (speed != 0)
        {
            time -= Time.deltaTime;
        }

        if (time <= 0)
        {
            time = 2f;
            if (left)
            {
                left = false;
            }
            else
            {
                left = true;
            }
        }
    }
}
