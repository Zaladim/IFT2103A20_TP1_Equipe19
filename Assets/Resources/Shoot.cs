using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public float speed = 100f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject projectile = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody projectileRigidBody = projectile.GetComponent<Rigidbody>();
            projectileRigidBody.AddForce(Vector3.forward * speed);
            projectileRigidBody.AddForce(Vector3.up * speed/2);

        }
    }
}
