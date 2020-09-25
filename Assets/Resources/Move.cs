using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed = 0f;
    private float time = 1f;
    private bool left = true;
    private GameObject projectile;
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

        projectile = GameObject.FindGameObjectWithTag("projectile");
        if (projectile.transform.position.z >= transform.position.z)
        {
            speed += 0.01f;
            Destroy(projectile);
        }
        
    }
}
