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

    void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.gameObject.CompareTag("Enemy")){
            Destroy(collision.gameObject);
         }
    }

}
