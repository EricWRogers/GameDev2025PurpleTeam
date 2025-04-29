using UnityEngine;

public class Barrier : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy"){
            Destroy(collision.gameObject);
        }
    }
}
