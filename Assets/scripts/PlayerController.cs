using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
        private Rigidbody2D body;
        public float speed = 10f;
 
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
 
    private void Update()
    {
        body.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.linearVelocity.y);
 
        if (Input.GetKey(KeyCode.Space))
            body.AddForce(new Vector2(body.linearVelocity.x,speed));
    }
}
