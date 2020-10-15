using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameObject.FindGameObjectWithTag("projectile") == null)
        {
            GameObject projectile = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            Destroy(projectile, 5);

        }
    }
}
