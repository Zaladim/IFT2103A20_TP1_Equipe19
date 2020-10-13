using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Move : MonoBehaviour
{

    public Vector3 velocity;
    
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p1 = transform.position;

        velocity += Physics.gravity * Time.deltaTime;
        Vector3 p2 = p1 + velocity * Time.deltaTime;

        p1 = p2;
        transform.position = p1;
    }
}
