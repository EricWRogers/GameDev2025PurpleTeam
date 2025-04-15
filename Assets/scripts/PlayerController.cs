using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
        private Rigidbody2D body;
        public float speed = 10f;
        public float jump = 50f;
        public bool isJumping;
        public Vector2 boxsize;
        public float castDistinace;
        public LayerMask groundLayer;
 
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
 
    private void FixedUpdate()
    {
        body.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.linearVelocity.y);
 
        if (Input.GetKey(KeyCode.Space) && isGrounded())
            body.AddForce(new Vector2(body.linearVelocity.x,jump));
            StartCoroutine(JumpCooldown());
    }


    public bool isGrounded(){
        if(Physics2D.BoxCast(transform.position,boxsize,0, -transform.up,castDistinace, groundLayer )) {
            return true;
        }
        else{
            return false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position-transform.up * castDistinace, boxsize );
    }

    private IEnumerator JumpCooldown()
    {
        isJumping = true;
        yield return new WaitForSeconds(0.4f);
        isJumping = false;
        Debug.Log("done");
    }
    //  private void OnCollisionEnter2D(Collision2D other)
    // {
    //     if(other.gameObject.CompareTag("Ground")){
    //         isJumping = false;
    //     }
    // }

    // private void OnCollisionExit2D(Collision2D other)
    // {
    //      if(other.gameObject.CompareTag("Ground")){
    //         isJumping = true;
    //     }
    // }
}
