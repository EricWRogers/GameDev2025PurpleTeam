
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    // Assign a Rigidbody component in the inspector to instantiate
    public GameObject bulletPrefab;
    public GameObject aoeAttack;
    private Vector3 bulletSpawn;
    public MicInput MicInputScript;
    private float NextFire;
    
    float FireRate = 0.5f;


    void Update()
    {
        bulletSpawn = new Vector3(1f,0f,0f);
        // Ctrl was pressed, launch a projectile
        if (MicInputScript.average > 0.5f && Time.time > NextFire)
        {
            NextFire = Time.time + FireRate;
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody2D clone;
            clone = Instantiate(bulletPrefab, transform.position + bulletSpawn, transform.rotation).GetComponent<Rigidbody2D>();

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.linearVelocity = transform.TransformDirection(Vector3.right * 10);
        }


        if (Input.GetButton("Fire2"))
        {
           aoeAttack.SetActive(true);
        }
        else
        {
            aoeAttack.SetActive(false);
        }
    }

}