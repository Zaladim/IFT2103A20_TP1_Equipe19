using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed = 0f;
    private float time = 1f;
    private bool left = true;
    private float radius = 0.25f;
    private GameObject[] projectiles;
    
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

        projectiles = GameObject.FindGameObjectsWithTag("projectile");

        foreach (GameObject projectile in projectiles)
        {
            if (Collide(projectile))
            {
                print("Kiwi" + projectile.transform.position.x);
                print("Kiwi3" + transform.position.x);
                speed += 0.01f;
                Destroy(projectile);
            }
        }

    }

    bool Collide(GameObject projectile)
    {
        if (projectile.transform.position.y + radius >= transform.position.y)
        {
            if (projectile.transform.position.z + radius >= transform.position.z - 0.25  &&
                projectile.transform.position.z - radius <= transform.position.z + 0.25)
            {
                if (projectile.transform.position.x + radius >= transform.position.x - 0.25 &&
                    projectile.transform.position.x - radius <= transform.position.x + 0.25)
                {
                    return true;
                }
            }
        }

        return false;
    }
    
}
