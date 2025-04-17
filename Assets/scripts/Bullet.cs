using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bullet : MonoBehaviour
{   
    public GameObject bulletPrefab;
    
    public float speed = 20;

    void Update() 
    {
        transform.Translate((transform.forward * speed * Time.deltaTime));
    }

}
