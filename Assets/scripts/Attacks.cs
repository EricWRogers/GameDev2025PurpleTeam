
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    // Assign a Rigidbody component in the inspector to instantiate
    public GameObject bulletPrefab;

    void Update()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody2D clone;
            clone = Instantiate(bulletPrefab, transform.position, transform.rotation).GetComponent<Rigidbody2D>();

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.linearVelocity = transform.TransformDirection(Vector3.forward * 10);
        }
    }
}